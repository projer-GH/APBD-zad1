namespace ConsoleApp2;

public class KontenerChlodniczy: Kontener
{
    public KontenerChlodniczy(double masaMax, double wysokosc, double wagaWlasna, double glebokosc) 
        : base(masaMax, wysokosc, wagaWlasna, glebokosc, 'C')
    {
    }
}