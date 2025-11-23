using UiPath.CodedWorkflows;
using System;

namespace PerformerfForACMESystemGenerateYearlyReport
{
    public class GoogleDocsFactory
    {
        public GoogleDocsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class DriveFactory
    {
        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection ITI_RPA_hosnygamal50_gmail_com__2 { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            ITI_RPA_hosnygamal50_gmail_com__2 = new UiPath.GSuite.Activities.Api.GmailConnection("1d2dbc5c-07cb-44c7-89bf-4e57e29ef259", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }
}