namespace LoanstepCore.Emails;

public class Email
{
    public EmailAddress EmailAddress { get; }
    public string Subject { get;  }
    public string EmailContent { get; }

    public Email(EmailAddress recipiant, string subject, string emailContent)
    {
        EmailAddress = recipiant;
        Subject = subject;
        EmailContent = emailContent;
    }
}