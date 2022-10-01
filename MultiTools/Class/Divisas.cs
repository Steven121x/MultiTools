using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTools.Class
{
    class Divisas
    {
        //Variable para guardar los datos de una conversion exitosa
        private double resultadoAll;
        //Metodos de conversiones 
        public void UsdToDop(double cantidad)
        {
            double resultado; //Variable donde se guarda el resultado
            double dolar = 54.01; //Peso dominicano
            resultado = cantidad * dolar;
            resultadoAll = resultado;
        }
        public void DopToUsd(double cantidad)
        {
            double resultado; //Variable donde se guarda el resultado
            double precioDolar = 54.01; //Peso dominicano
            resultado = cantidad / precioDolar;
            resultadoAll = resultado;
        }
        public void UsdToEur(double cantidad)
        {
            double resultado; //Variable donde se guarda el resultado
            double precioEuro = 0.98; //Dolares USA
            resultado = cantidad / precioEuro;
            resultadoAll = resultado;
        }
        public void SolesToUsd(double cantidad)
        {
            double resultado; //Variable donde se guarda el resultado
            double precioDolar = 3.90; //Soles peruanos
            resultado = cantidad / precioDolar;
            resultadoAll = resultado;
        }
        public void MxToUsd(double cantidad)
        {
            double resultado; //Variable donde se guarda el resultado
            double precioUsd = 20.07; //Pesos mexicano
            resultado = cantidad / precioUsd;
            resultadoAll = resultado;
        }

        public double GetResultadoDi()
        {
            return resultadoAll;
        }
    }
}
