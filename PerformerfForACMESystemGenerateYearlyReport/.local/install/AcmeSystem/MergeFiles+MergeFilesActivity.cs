using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;

namespace PerformerfForACMESystemGenerateYearlyReport.AcmeSystem
{
    [System.ComponentModel.Browsable(false)]
    public class MergeFilesActivity : System.Activities.Activity
    {
        public InArgument<System.String> reportFolder { get; set; }
        public InArgument<System.String> taxId { get; set; }
        public InArgument<System.String> year { get; set; }
        public OutArgument<System.String> Output { get; set; }

        public MergeFilesActivity()
        {
            this.Implementation = () =>
            {
                return new MergeFilesActivityChild()
                {
                    reportFolder = (this.reportFolder == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "reportFolder") : (InArgument<System.String>)Argument.CreateReference((Argument)this.reportFolder, "reportFolder")),
                    taxId = (this.taxId == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "taxId") : (InArgument<System.String>)Argument.CreateReference((Argument)this.taxId, "taxId")),
                    year = (this.year == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "year") : (InArgument<System.String>)Argument.CreateReference((Argument)this.year, "year")),
                    Output = (this.Output == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "Output") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.Output, "Output")),
                };
            };
        }
    }

    internal class MergeFilesActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<System.String> reportFolder { get; set; }
        public InArgument<System.String> taxId { get; set; }
        public InArgument<System.String> year { get; set; }
        public OutArgument<System.String> Output { get; set; }
        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public MergeFilesActivityChild()
        {
            DisplayName = "MergeFiles";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var var_reportFolder = reportFolder.Get(context);
            var var_taxId = taxId.Get(context);
            var var_year = year.Get(context);
            var codedWorkflow = new global::PerformerfForACMESystemGenerateYearlyReport.MergeFiles();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>() { UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints }), context);
            var result = await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext() { RelativeFilePath = "AcmeSystem\\MergeFiles.cs" });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                CodedExecutionHelper.Run(() =>
                {
                    {
                        var result = codedWorkflow.Execute(var_reportFolder, var_taxId, var_year);
                        newResult = new System.Collections.Generic.Dictionary<string, object>
                        {
                            {
                                "Output",
                                result
                            }
                        };
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext() { RelativeFilePath = "AcmeSystem\\MergeFiles.cs", Exception = exception });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
                Output.Set(endContext, (System.String)result["Output"]);
            };
        }
    }
}