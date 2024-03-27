namespace ConsoleApp2;

public class Kontenerowiec
{
    private Kontener[] kontenery;

    private double MaxPredkosc;
    private int MaxKontenerow;
    private double MaxWaga;
    private int at = 0;


    public Kontenerowiec(double maxPredkosc, int maxKontenerow, double maxWaga)
    {
        MaxPredkosc = maxPredkosc;
        MaxKontenerow = maxKontenerow;
        MaxWaga = maxWaga;

        kontenery = new Kontener[maxKontenerow];
    }

    public void ZaladujNaStatek(Kontener kon)
    {
        if (MaxKontenerow < at)
        {
            Console.WriteLine("Załadowano już maksymalną ilość kontenerów");
        }
        
        kontenery[at] = kon;
        at++;
    }

    public void usunKontenerZeStatku()
    {
        if (at != 0)
        {
            at--;
            kontenery[at] = null;
        }
        else
        {
            Console.WriteLine("Na statku nie ma kontenerów");
        }
    }

    public void ZastapKontener(Kontener kontener,int numer)
    {
        for (int i = 0; i < kontenery.Length; i++)
        {
            if(kontenery[i]!=null)
            if (kontenery[i].getNumber() == numer)
            {
                kontenery[i] = kontener;
                Console.WriteLine("Zastąpiono kontenery");
            }
        } 
    }

    public void WypiszInformacjeOLadunku()
    {
        for (int i = 0; i < kontenery.Length; i++)
        {
            if(kontenery[i]!=null)
                kontenery[i].PrzedstawSie();
        }
    }
    
    
    public void ZaladujNaStatek(Kontener[] tab)
    {
        if (MaxKontenerow < at+tab.Length)
        {
            Console.WriteLine("Załadowano już maksymalną ilość kontenerów");
        }

        for (int i = 0; i < tab.Length; i++)
        {
            kontenery[at] = tab[i];
            at++;
        }
    }
    
    
}