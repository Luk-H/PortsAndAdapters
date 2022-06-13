using LoanstepCore.Emails;

namespace LoanstepCore.Integration;

public interface IEmailClient
{
    public void SendFromNoreply(Email email);
}