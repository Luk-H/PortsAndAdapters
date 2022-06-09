using LoanstepCore.Entities;

namespace LoanstepCore.Integration;

public interface IKreditsClient
{
    Task<KreditzReport> FetchKreditsForSsn(string ssn);
}