namespace LoanstepCore.Entities;

//we dont have to abstract things over the boundary, only if it makes sense 
public class KreditzReport
{
    

    public static KreditzReport CreateReport()
    {
        return new KreditzReport();
    }
    

}