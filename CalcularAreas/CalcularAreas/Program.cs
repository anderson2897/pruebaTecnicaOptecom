using CalcularAreas.Controller;
using CalcularAreas.Data.Interfaz;
using CalcularAreas.Data.Logic;



class Program
{
    static void Main()
    {

        ICalculate calculate = new Calculate();
        Figures.Getfigures(calculate);
        System.Threading.Thread.Sleep(60000);

    }
}

