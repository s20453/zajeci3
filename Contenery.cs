
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

using System;

public class ToHaveForContanor : Exception
{
    public ToHaveForContanor()
    {
    }

    public ToHaveForContanor(string message)
        : base(message)
    {
    }

    public ToHaveForContanor(string message, Exception inner)
        : base(message, inner)
    {
    }
}
public class KontenerNaPlyny() : Contener
{  
    interface




}
public class KontenerNaGas() : Contener
{




}
public class KontenerChlodniczy() : Contener
{
    private void contenercrate()
    {


    }



}
public class Contener : ToHaveForContanor
{
    int waga,
        wysokosc,
        waga_wlasna,
        glembokosc,
        maxladownosc;
    string numer_seryjny;
    private void contenercreate(int waga, int wysokosc, int waga_wlasna, int glembokosc, int maxladownosc)
    {
        this.waga = waga;
        this.wysokosc = wysokosc;
        this.waga_wlasna = waga_wlasna;
        this.glembokosc = glembokosc;
        this.maxladownosc = maxladownosc;

    }
    private void contenerload(int waga) {
        if (waga + this.waga>= this.maxladownosc)
        {
            throw new ToHaveForContanor("ladunek sie nie miesci");
        }
        else
        {
            this.waga += waga;
        }
    }


        private void contenerclear()
    {
        waga = 0;
    }
}
    public class Program
{   
   
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


    }
}