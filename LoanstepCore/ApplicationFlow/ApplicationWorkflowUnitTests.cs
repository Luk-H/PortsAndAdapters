using LoanstepCore.Emails;
using LoanstepCore.Entities;
using LoanstepCore.Integration;
using Moq;
using NUnit.Framework;

namespace LoanstepCore.ApplicationFlow;

[TestFixture]
public class ApplicationWorkflowUnitTests
{
    [Test]
    public void SendsRejectsionEmailsToJhonnys()
    {
        var application = new Application(new Borrower("John", "Jhonsson", new EmailAddress("John@hotmail.com")), 1500);
        var emailClient = new Mock<IEmailClient>();
        var sut = new ApplicantWorkflow(emailClient.Object);

        sut.StartApplicationWorkflow(application);
        
        emailClient.Verify(p => p.SendFromNoreply(It.IsAny<Email>()), Times.Once());
    }
}