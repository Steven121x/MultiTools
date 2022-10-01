using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MultiTools.Class
{
    class ConsumidorAPI
    {
        //Variable para guardar el resultado
        private string resultadoAPI;

        //Clase WebClient para consumir una url o api 

        WebClient Consumidor = new WebClient();
        
        public void ConsumirAPI(string url)
        {

            resultadoAPI = Consumidor.DownloadString(url); 
        }

        public string GetResultado()
        {
            return resultadoAPI;
        }
    }
}
