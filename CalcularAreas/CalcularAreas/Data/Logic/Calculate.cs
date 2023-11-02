using CalcularAreas.Data.Interfaz;

namespace CalcularAreas.Data.Logic
{
    public class Calculate : ICalculate
    {

        public async Task<double> ValidateNumberTriangle()
        {
            double baseTriangule;
            double heightTriangule;
            bool isValidBase, isValidHigt;
            Console.WriteLine("Calculadora de área de triángulo");
            do
            {
                isValidBase = GetDoubleFromUser("ingrese la base del triángulo: ", out baseTriangule);

            } while (!isValidBase);
            do
            {
                isValidHigt = GetDoubleFromUser("ingrese la altura del triángulo: ", out heightTriangule);
            } while (!isValidHigt);
            return await CalculateAreaTriangle(baseTriangule, heightTriangule);
        }

        public async Task<double> ValidateNumberCircle()
        {
            double radiusCircle;
            bool isRadiusBase;

            Console.WriteLine("Calculadora de área de círculo");
            do
            {
                isRadiusBase = GetDoubleFromUser("ingrese la base del triángulo: ", out radiusCircle);

            } while (!isRadiusBase);
            return await CalculateAreaCircle(radiusCircle);

        }

        private bool GetDoubleFromUser(string prompt, out double value)
        {

            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private async Task<double> CalculateAreaTriangle(double baseTriangule, double heightTriangule)
        {
            try
            {
                double area = (baseTriangule * heightTriangule) / 2;
                return await Task.FromResult(area);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }

        private async Task<double> CalculateAreaCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }


    }
}
