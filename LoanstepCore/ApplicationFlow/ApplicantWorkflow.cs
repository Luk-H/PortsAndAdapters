using LoanstepCore.Emails;
using LoanstepCore.Entities;
using LoanstepCore.Integration;

namespace LoanstepCore.ApplicationFlow;

public class ApplicantWorkflow
{
    private readonly IEmailClient _emailClient;

    public ApplicantWorkflow(IEmailClient emailClient)
    {
        _emailClient = emailClient;
    }
    public void StartApplicationWorkflow(Application application)
    {
        if (application.Borrower.FirstName.Equals("John"))
        {
            //reject early, no Jhons can take a loan beacuse buiessniess reason
            var emailTemplate = new RejectBecauseEmailTemplate(application.Borrower);
            var email = emailTemplate.generateEmail();
            
            _emailClient.SendFromNoreply(email);
        }
    }
}