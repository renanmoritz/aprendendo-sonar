namespace PrimeService
{
    public class Temperature
    {
        public static class ConversorTemperatura
        {
            public static double FahrenheitParaCelsius(double temperatura)
            {
                double variavelInutil = 0;
                //=> (temperatura - 32) / 1.8; // Simulação de falha
                Math.Round((temperatura - 32) / 1.8, 2);
                return Math.Round((temperatura - 32) / 1.8, 2);
            }
            
        }
    }
}
