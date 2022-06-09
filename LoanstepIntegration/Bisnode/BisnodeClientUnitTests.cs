using Moq;
using NUnit.Framework;

namespace LoanstepIntegration;

[TestFixture]
public class BisnodeClientUnitTests
{
    [Test]
    public void CreatesWithBearer()
    {
        var httpClient = new HttpClient();
        //Internal accessibility for our unit tests
        var client = new BisnodeReportClient(httpClient, "TestToken");

        client.fetchReport("198703014343");
        
        Assert.That(httpClient.authorizationHeader, Is.EqualTo("TestToken"));
    }
}