using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace calculadoraWebService
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int suma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        [WebMethod]
        public int resta(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        [WebMethod]
        public int multiplicacion(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        [WebMethod]
        public int division(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }
}
