using LoanstepCore.Entities;
using LoanstepCore.Integration;

namespace LoanstepCore.Services;

public class CreditReportService
{
    // The implementation detail of how this was fetched is abstracted, we know it returns CreditReports in a format we in the domain care about
    private readonly ICreditReportClient _client;
    public CreditReportService(ICreditReportClient client)
    {
        _client = client;
    }

    public async Task<CreditReport> GetReportOrCreateIfNeeded(string ssn)
    {
        //Look in database
        
        //If does not exist or is expierd
        
        //Notice how we dont pass in a snowflake HttpClient into the method.
        var report = await _client.fetchReport(ssn);
        //save report
        return report;
    }


}