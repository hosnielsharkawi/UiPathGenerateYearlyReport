using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using PerformerfForACMESystemGenerateYearlyReport;

[assembly: WorkflowRunnerServiceAttribute(typeof(PerformerfForACMESystemGenerateYearlyReport.WorkflowRunnerService))]
namespace PerformerfForACMESystemGenerateYearlyReport
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the AcmeSystem/CloaseBrowser.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloaseBrowser(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\CloaseBrowser.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AcmeSystem/CloaseBrowser.xaml
        /// </summary>
        public void CloaseBrowser(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\CloaseBrowser.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloseAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AcmeSystem/DownloadMonthlyReport.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string DownloadMonthlyReport(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\DownloadMonthlyReport.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "in_TransactionItem", in_TransactionItem } }, default, isolated, default, GetAssemblyName());
            return (string)result["out_YearlyReportPath"];
        }

        /// <summary>
        /// Invokes the AcmeSystem/DownloadMonthlyReport.xaml
        /// </summary>
        public string DownloadMonthlyReport(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\DownloadMonthlyReport.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "in_TransactionItem", in_TransactionItem } }, default, default, default, GetAssemblyName());
            return (string)result["out_YearlyReportPath"];
        }

        /// <summary>
        /// Invokes the AcmeSystem/Draft.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Draft(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\Draft.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AcmeSystem/Draft.xaml
        /// </summary>
        public void Draft()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\Draft.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object> { { "in_TransactionNumber", in_TransactionNumber }, { "in_Config", in_Config }, { "io_dt_TransactionData", io_dt_TransactionData } }, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object> { { "in_TransactionNumber", in_TransactionNumber }, { "in_Config", in_Config }, { "io_dt_TransactionData", io_dt_TransactionData } }, default, default, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetTransactionDataTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void GetTransactionDataTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplicationsTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void InitAllApplicationsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object> { { "in_ConfigFile", in_ConfigFile }, { "in_ConfigSheets", in_ConfigSheets } }, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object> { { "in_ConfigFile", in_ConfigFile }, { "in_ConfigSheets", in_ConfigSheets } }, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllSettingsTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void InitAllSettingsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllProcesses(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AcmeSystem/LoginPage.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void LoginPage(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\LoginPage.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AcmeSystem/LoginPage.xaml
        /// </summary>
        public void LoginPage(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\LoginPage.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { { "in_OrchestratorQueueName", in_OrchestratorQueueName }, { "in_OrchestratorQueueFolder", in_OrchestratorQueueFolder } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { { "in_OrchestratorQueueName", in_OrchestratorQueueName }, { "in_OrchestratorQueueFolder", in_OrchestratorQueueFolder } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void MainTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
        public void MainTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AcmeSystem/MergeFiles.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.String MergeFiles(System.String reportFolder, System.String taxId, System.String year, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\MergeFiles.cs", new Dictionary<string, object> { { "reportFolder", reportFolder }, { "taxId", taxId }, { "year", year } }, default, isolated, default, GetAssemblyName());
            return (System.String)result["Output"];
        }

        /// <summary>
        /// Invokes the AcmeSystem/MergeFiles.cs
        /// </summary>
        public System.String MergeFiles(System.String reportFolder, System.String taxId, System.String year)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\MergeFiles.cs", new Dictionary<string, object> { { "reportFolder", reportFolder }, { "taxId", taxId }, { "year", year } }, default, default, default, GetAssemblyName());
            return (System.String)result["Output"];
        }

        /// <summary>
        /// Invokes the AcmeSystem/openBrowser.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void openBrowser(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\openBrowser.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AcmeSystem/openBrowser.xaml
        /// </summary>
        public void openBrowser(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\openBrowser.xaml", new Dictionary<string, object> { { "in_Config", in_Config } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object> { { "in_TransactionItem", in_TransactionItem }, { "in_Config", in_Config } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        public void Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object> { { "in_TransactionItem", in_TransactionItem }, { "in_Config", in_Config } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void ProcessTestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
        public void ProcessTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "in_SystemException", in_SystemException }, { "in_QueueRetry", in_QueueRetry }, { "io_RetryNumber", io_RetryNumber }, { "io_TransactionNumber", io_TransactionNumber } }, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "in_SystemException", in_SystemException }, { "in_QueueRetry", in_QueueRetry }, { "io_RetryNumber", io_RetryNumber }, { "io_TransactionNumber", io_TransactionNumber } }, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object> { { "in_BusinessException", in_BusinessException }, { "in_TransactionField1", in_TransactionField1 }, { "in_TransactionField2", in_TransactionField2 }, { "in_TransactionID", in_TransactionID }, { "in_SystemException", in_SystemException }, { "in_Config", in_Config }, { "in_TransactionItem", in_TransactionItem }, { "io_RetryNumber", io_RetryNumber }, { "io_TransactionNumber", io_TransactionNumber }, { "io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions } }, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object> { { "in_BusinessException", in_BusinessException }, { "in_TransactionField1", in_TransactionField1 }, { "in_TransactionField2", in_TransactionField2 }, { "in_TransactionID", in_TransactionID }, { "in_SystemException", in_SystemException }, { "in_Config", in_Config }, { "in_TransactionItem", in_TransactionItem }, { "io_RetryNumber", io_RetryNumber }, { "io_TransactionNumber", io_TransactionNumber }, { "io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions } }, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string TakeScreenshot(string in_Folder, string io_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object> { { "in_Folder", in_Folder }, { "io_FilePath", io_FilePath } }, default, isolated, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object> { { "in_Folder", in_Folder }, { "io_FilePath", io_FilePath } }, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the AcmeSystem/UpdateClientWorkItem.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void UpdateClientWorkItem(System.Collections.Generic.Dictionary<string, object> in_Config, string in_HashText, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\UpdateClientWorkItem.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "in_HashText", in_HashText } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AcmeSystem/UpdateClientWorkItem.xaml
        /// </summary>
        public void UpdateClientWorkItem(System.Collections.Generic.Dictionary<string, object> in_Config, string in_HashText)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\UpdateClientWorkItem.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "in_HashText", in_HashText } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the AcmeSystem/UploadYearlyReport.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string UploadYearlyReport(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, string in_YearlyReportPath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\UploadYearlyReport.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "in_TransactionItem", in_TransactionItem }, { "in_YearlyReportPath", in_YearlyReportPath } }, default, isolated, default, GetAssemblyName());
            return (string)result["out_HashText"];
        }

        /// <summary>
        /// Invokes the AcmeSystem/UploadYearlyReport.xaml
        /// </summary>
        public string UploadYearlyReport(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, string in_YearlyReportPath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"AcmeSystem\UploadYearlyReport.xaml", new Dictionary<string, object> { { "in_Config", in_Config }, { "in_TransactionItem", in_TransactionItem }, { "in_YearlyReportPath", in_YearlyReportPath } }, default, default, default, GetAssemblyName());
            return (string)result["out_HashText"];
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void WorkflowTestCaseTemplate(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void WorkflowTestCaseTemplate()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}