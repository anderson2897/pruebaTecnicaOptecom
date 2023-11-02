namespace CalcularAreas.Data.Interfaz
{
    public interface ICalculate
    {
        Task<double> ValidateNumberTriangle();
        Task<double> ValidateNumberCircle();
    }
}
