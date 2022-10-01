using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MultiTools.Class
{
    
    class IPlookup
    {
        private string informacionIP;
        WebClient LookIpAdress = new WebClient(); //WebClient para consumir el string/json de la api

        //Metodo para obtener la adress de una ip ejemplo | 127.0.0.1
        public void GetAdress(string ip) 
        {
           informacionIP = LookIpAdress.DownloadString($"http://ip-api.com/json/{ip}");
        }

        public string GetInformacion()
        {
            return informacionIP;
        }
    }
}
