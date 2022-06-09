using LoanstepCore.Entities;
using LoanstepCore.Integration;

namespace LoanstepIntegration;

//We can(and probably should) return the domain models we can also throw domain exceptions etc
public class BisnodeReportClient : ICreditReportClient
{
    private readonly HttpClient _client;
    public BisnodeReportClient(string token)
    {
        _client = GetHttpCientWithAuth(new HttpClient(), token);
    }

    //For unit tests and stuff like that
    internal BisnodeReportClient(HttpClient client, string token)
    {
        _client = GetHttpCientWithAuth(client, token);
    }
    

    public async Task<CreditReport> fetchReport(string ssn)
    {
        
        var response = _client.MakeHttpCall();

        //We can make it fit our domain, instead of our domain having to do this, knowing about an api response type
        return CreditReport.CreateReport(response.FirstName, response.LastName, response.Age > 18);
    }

    private HttpClient GetHttpCientWithAuth(HttpClient httpClient, string token)
    {
        httpClient.SetBearer(token);
        return httpClient;
    }
}








public class HttpClient
{
    public string authorizationHeader { get; private set; }
    public void SetBearer(string httpToken)
    {
        authorizationHeader = httpToken;
    }
    
    public BisnodeResponseDTO MakeHttpCall()
    {
        return new BisnodeResponseDTO()
        {
            Age = 19,
            FirstName = "John",
            LastName = "Smith"
        };
    }
}