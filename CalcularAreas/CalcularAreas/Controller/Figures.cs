using CalcularAreas.Data.Interfaz;

namespace CalcularAreas.Controller
{
    public class Figures
    {

        private readonly ICalculate _calculate;

        public Figures(ICalculate calculate)
        {
            _calculate = calculate;
        }

        public static async void Getfigures(ICalculate calculate)
        {
            var processTask = new Figures(calculate);
            await processTask.ExecutProcess();
        }

        public async Task ExecutProcess()
        {
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Calcular el área de un triángulo");
            Console.WriteLine("2. Calcular el área de un círculo");
            Console.Write("Digita el número de la opción: ");
            string opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1":
                    var areaTriangle = await _calculate.ValidateNumberTriangle();
                    if (areaTriangle != 0)
                    {
                        Console.WriteLine("Área de triángulo: " + areaTriangle);
                    }
                    else
                    {
                        Console.WriteLine("Error al calcular el área del triángulo");
                    }
                    break;
                case "2":
                    var areaCircle = await _calculate.ValidateNumberCircle();
                    if (areaCircle != 0)
                    {
                        Console.WriteLine("Área de círculo: " + areaCircle);
                    }
                    else
                    {
                        Console.WriteLine("Error al calcular el área del círculo");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona 1 o 2.");
                    break;
            }

        }

    }
}
