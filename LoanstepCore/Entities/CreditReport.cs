namespace LoanstepCore.Entities;

//This is not a Poco, it knows about entity framework
public class CreditReport
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public bool IsOver18 { get; private set; }

    public static CreditReport CreateReport(string firstName, string lastName, bool isOver18)
    {
        var creditReport = new CreditReport();
        creditReport.FirstName = firstName;
        creditReport.LastName = lastName;
        creditReport.IsOver18 = isOver18;
        return creditReport;
    }
    
    public CreditReportVm toViewModel()
    {
        return new CreditReportVm()
        {
            Id = this.Id
        };
    }
}