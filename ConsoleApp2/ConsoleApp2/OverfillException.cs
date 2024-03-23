namespace ConsoleApp2;

public class OverfillException : Exception
{
    public OverfillException()
        : base("Za duży załadunek, wybierz mniejszy") { }   
}