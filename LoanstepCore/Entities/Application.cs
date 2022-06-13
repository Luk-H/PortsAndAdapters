using LoanstepCore.Entities;

namespace LoanstepCore.Entities;

public class Application
{
    public Borrower Borrower { get; }
    public int Ammount { get; }

    public Application(Borrower borrower, int ammount)
    {
        Borrower = borrower;
        Ammount = ammount;
    }
}