using PerformerfForACMESystemGenerateYearlyReport.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.Api.Models;
using UiPath.Testing.Activities.Models;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using System.Linq;
using System.IO;
using System.Text;
using OfficeOpenXml;
namespace PerformerfForACMESystemGenerateYearlyReport
{
    public class MergeFiles : CodedWorkflow
    {
        [Workflow]
        public string Execute(string reportFolder, string taxId, string year)
        {
           // Validate basic inputs - NO Exceptions here!
            if (string.IsNullOrWhiteSpace(reportFolder))
            {
                Console.WriteLine("[WARNING] reportFolder is empty. Skipping merge...");
                return null;
            }
            
            if (string.IsNullOrWhiteSpace(taxId))
            {
                Console.WriteLine("[WARNING] taxId is empty. Skipping merge...");
                return null;
            }
            
            if (string.IsNullOrWhiteSpace(year))
            {
                Console.WriteLine("[WARNING] year is empty. Skipping merge...");
                return null;
            }
            
            if (!Directory.Exists(reportFolder))
            {
                Console.WriteLine($"[WARNING] Report folder does not exist: {reportFolder}. Skipping merge...");
                return null;
            }


            ExcelPackage.License.SetNonCommercialPersonal("Hosni ElSharkawi");
            // كل ملفات الريپورت اللي تخص الـ TaxID ده
            var csvFiles = Directory.GetFiles(reportFolder, $"Report-{taxId}-*.csv");

            if (csvFiles.Length == 0){
                Console.WriteLine($"[INFO] No monthly reports found for {taxId}. Skipping merge...");
                return null;
            }

            DataTable yearlyTable = null;

            // نمشي على كل ملف بالترتيب
            foreach (var file in csvFiles.OrderBy(f => f))
            {
                var monthlyTable = ReadCsvToDataTable(file);

                if (yearlyTable == null)
                    yearlyTable = monthlyTable.Copy();  // نفس الأعمدة

                foreach (DataRow row in monthlyTable.Rows)
                    yearlyTable.ImportRow(row);

                // امسح ملف الشهر بعد ما ندمجه
                File.Delete(file);
            }

            if (yearlyTable == null || yearlyTable.Rows.Count == 0)
                {
                Console.WriteLine($"[Warning] No monthly reports found for TaxID {taxId}. Skipping merge.");
                return null; // Return null path to indicate skip
                }

            // ملف الإكسيل المؤقت داخل reportFolder
            string tempYearlyPath = Path.Combine(
                reportFolder,
                $"Yearly-Report-{year}-{taxId}.xlsx"
            );

            // إنشاء الإكسيل
            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("YearlyReport");
                ws.Cells["A1"].LoadFromDataTable(yearlyTable, true);
                package.SaveAs(new FileInfo(tempYearlyPath));
            }

            // فولدر الإخراج داخل المشروع: Data/output
            string projectRoot = Environment.CurrentDirectory; // مسار المشروع الحالي
            string outputFolder = Path.Combine(projectRoot, "Data", "Output");
            Directory.CreateDirectory(outputFolder);

            string finalPath = Path.Combine(
                outputFolder,
                Path.GetFileName(tempYearlyPath)
            );

            // انقل الملف النهائي من reportFolder إلى Data/output
            if (File.Exists(finalPath))
                File.Delete(finalPath);

            File.Move(tempYearlyPath, finalPath);

            // رجّع المسار النهائي عشان تستخدمه في خطوة Upload
            return finalPath;
        }

        /// <summary>
        /// يقرأ CSV (أول صف header) ويحوله لـ DataTable.
        /// </summary>
        private DataTable ReadCsvToDataTable(string csvPath)
        {
            var dt = new DataTable();

            using (var reader = new StreamReader(csvPath, Encoding.UTF8))
            {
                bool isHeader = true;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var values = line.Split(',');

                    if (isHeader)
                    {
                        foreach (var col in values)
                            dt.Columns.Add(col.Trim());
                        isHeader = false;
                    }
                    else
                    {
                        // لو عدد القيم أقل من الأعمدة نكمّلها بقيم فاضية
                        while (values.Length < dt.Columns.Count)
                            values = values.Concat(new[] { string.Empty }).ToArray();

                        dt.Rows.Add(values);
                    }
                }
            }

            return dt;
        }
    }
}
  