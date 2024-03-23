using ConsoleApp2;

public class Program
{
    public static void Main(string[] args)
    {
        KontenerNaPlyny k = new KontenerNaPlyny(2.3, 12.2, 12.3, 11.2,true);
        k.PrzedstawSie();
        KontenerNaPlyny k1 = new KontenerNaPlyny(10, 12.2, 12.3, 11.2,false);
        k1.PrzedstawSie();
        k1.Zaladuj(5);

        KontenerNaGaz g = new KontenerNaGaz(10, 22, 12, 12, 1212);
        
    }
}