using DispatcherfForACMESystemGenerateYearlyReport.ObjectRepository;
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
using System.Text.RegularExpressions;

namespace DispatcherfForACMESystemGenerateYearlyReport
{
   public class RegexForClientData : CodedWorkflow
{
    public string ClientDataRaw { get; set; }
    public string TaxID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }

    [Workflow]
    public (string ClientTaxID, string ClientName, string ClientAddress, string ClientCity) Execute(string clientInfoText)
    {
        var idMatch = Regex.Match(clientInfoText, @"TaxID:\s*([^\r\n]+)");
        var nameMatch = Regex.Match(clientInfoText, @"Name:\s*([^\r\n]+)");
        var addressMatch = Regex.Match(clientInfoText, @"Address:\s*([^\r\n]+)");
        var cityMatch = Regex.Match(clientInfoText, @"City:\s*([^\r\n]+)");

    string id = idMatch.Success ? idMatch.Groups[1].Value.Trim() : "";
    string name = nameMatch.Success ? nameMatch.Groups[1].Value.Trim() : "";
    string country = addressMatch.Success ? addressMatch.Groups[1].Value.Trim() : "";
    string city = cityMatch.Success ? cityMatch.Groups[1].Value.Trim() : "";    
        
        return (id, name, country, city );
    }
}
}