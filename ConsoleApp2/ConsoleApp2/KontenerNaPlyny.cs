namespace ConsoleApp2;

public class KontenerNaPlyny:Kontener, IHazardNotifier
{
    private bool czyBezpieczny;
    public KontenerNaPlyny(double masaMax, double wysokosc, double wagaWlasna, double glebokosc,bool czyBezpieczny)
        : base(masaMax, wysokosc, wagaWlasna, glebokosc, 'L')
    {
        this.czyBezpieczny = czyBezpieczny;
        if(czyBezpieczny == false)
            PrzekazInformacje();
        
    }

    public void Zaladuj(double ladunek)
    {
        if (czyBezpieczny == true)
        {
            masaMax = masaMax * 0.9;
        }
        else
        {
            masaMax = masaMax * 0.5;
            
        }
        
        masa += ladunek;
        try
        {

            if (masa > masaMax)
                throw new OverfillException();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            masa = 0;
        }  
        Console.WriteLine("Kontener załadowany");
    }

    public void PrzekazInformacje()
    {
        Console.WriteLine("Uwaga, ładunek niebezpieczny w kontenerze "+nazwa+", maksymalna masa załadunku została zredukowana o połowe");
    }
}