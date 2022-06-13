using System.Net;
using System.Net.Mail;
using LoanstepCore.Emails;
using LoanstepCore.Integration;

namespace LoanstepIntegration;

public class SMTPEmailClient : IEmailClient
{
    private readonly string _host;
    private readonly int _port;
    private readonly string _email;
    private readonly string _password;

    public SMTPEmailClient(string host, int port, string email, string password)
    {
        _host = host;
        _port = port;
        _email = email;
        _password = password;
    }
        
    public void SendFromNoreply(Email email)
    {
        var client = GetClient();
        
         client.SendAsync("noreply@loanstep.se", email.EmailAddress.FullAddress, email.Subject, email.EmailContent, null);
    }

    private SmtpClient GetClient()
    {
        var smtpClient = new SmtpClient(_host)
        {
            Port = _port,
            Credentials = new NetworkCredential(_email, _password),
            EnableSsl = true,
        };
        return smtpClient;
    }
}