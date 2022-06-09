using LoanstepCore.Entities;

namespace LoanstepCore.Integration;

//We code against this interface, in fact we cant do anything else
public interface ICreditReportClient
{
    //We make a minimal interface that does not leak method of transport.
    Task<CreditReport> fetchReport(string ssn);
}