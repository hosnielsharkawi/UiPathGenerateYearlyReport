using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;

namespace DispatcherforACMESystemGenerateYearlyReportExercise
{
    [System.ComponentModel.Browsable(false)]
    public class RegexForClientDataActivity : System.Activities.Activity
    {
        public InArgument<System.String> clientInfoText { get; set; }
        public OutArgument<System.String> ClientTaxID { get; set; }
        public OutArgument<System.String> ClientName { get; set; }
        public OutArgument<System.String> ClientAddress { get; set; }
        public OutArgument<System.String> ClientCity { get; set; }

        public RegexForClientDataActivity()
        {
            this.Implementation = () =>
            {
                return new RegexForClientDataActivityChild()
                {
                    clientInfoText = (this.clientInfoText == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "clientInfoText") : (InArgument<System.String>)Argument.CreateReference((Argument)this.clientInfoText, "clientInfoText")),
                    ClientTaxID = (this.ClientTaxID == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "ClientTaxID") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.ClientTaxID, "ClientTaxID")),
                    ClientName = (this.ClientName == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "ClientName") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.ClientName, "ClientName")),
                    ClientAddress = (this.ClientAddress == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "ClientAddress") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.ClientAddress, "ClientAddress")),
                    ClientCity = (this.ClientCity == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "ClientCity") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.ClientCity, "ClientCity")),
                };
            };
        }
    }

    internal class RegexForClientDataActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<System.String> clientInfoText { get; set; }
        public OutArgument<System.String> ClientTaxID { get; set; }
        public OutArgument<System.String> ClientName { get; set; }
        public OutArgument<System.String> ClientAddress { get; set; }
        public OutArgument<System.String> ClientCity { get; set; }
        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public RegexForClientDataActivityChild()
        {
            DisplayName = "RegexForClientData";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var var_clientInfoText = clientInfoText.Get(context);
            var codedWorkflow = new global::DispatcherforACMESystemGenerateYearlyReportExercise.RegexForClientData();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>() { UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints }), context);
            var result = await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext() { RelativeFilePath = "RegexForClientData.cs" });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                CodedExecutionHelper.Run(() =>
                {
                    {
                        var result = codedWorkflow.Execute(var_clientInfoText);
                        newResult = new System.Collections.Generic.Dictionary<string, object>
                        {
                            {
                                "ClientTaxID",
                                result.ClientTaxID
                            },
                            {
                                "ClientName",
                                result.ClientName
                            },
                            {
                                "ClientAddress",
                                result.ClientAddress
                            },
                            {
                                "ClientCity",
                                result.ClientCity
                            },
                        };
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext() { RelativeFilePath = "RegexForClientData.cs", Exception = exception });
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
                ClientTaxID.Set(endContext, (System.String)result["ClientTaxID"]);
                ClientName.Set(endContext, (System.String)result["ClientName"]);
                ClientAddress.Set(endContext, (System.String)result["ClientAddress"]);
                ClientCity.Set(endContext, (System.String)result["ClientCity"]);
            };
        }
    }
}