using LoanstepCore.Entities;

namespace LoanstepCore.Integration;

public class FakeCreditReportClient : ICreditReportClient
{
    public async Task<CreditReport> fetchReport(string ssn)
    {
        return CreditReport.CreateReport("Joe", "Blake", true);
    }
}