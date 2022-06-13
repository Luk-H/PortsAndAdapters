using System.Reflection;
using LoanstepCore.Emails;
using LoanstepCore.Entities;

namespace LoanstepCore.ApplicationFlow;

public class RejectBecauseEmailTemplate : IEmailTemplate
{
    private readonly Borrower _borrower;
    public RejectBecauseEmailTemplate(Borrower borrower)
    {
        _borrower = borrower;
    }
    
    public Email generateEmail()
    {
        var body = generateBody();

        return new Email(_borrower.EmailAddress, "Loanstep avslag", body) ;
    }
    
    
    private string generateBody()
    {
        var text = ReadResource("ApplicationFlow\\RejectBeacuseEmailTemplate.html");
        // Could pass this to a helper with logic for all borrower props
        text.Replace("%FirstName%", _borrower.FirstName);
        text.Replace("%LastName%", _borrower.LastName);

        return text;
    }
    private string ReadResource(string name)
    {
        // Determine path
        var assembly = Assembly.GetExecutingAssembly();
        string resourcePath = name;
        
        using (StreamReader reader = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), resourcePath)))
        {
            return reader.ReadToEnd();
        }
    }
}