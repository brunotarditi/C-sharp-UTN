using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de Convert
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class Convert : System.Web.Services.WebService
{

    public Convert()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }
    [WebMethod]
    public string Convertir(string a, string b, double valor)
    {
        string cadena = "";
        switch (a)
        {
            case "Kilometro":
                double resultado;
                switch (b)
                {
                    case "Metro":
                        resultado = valor * 1000;
                        cadena = resultado.ToString() + " m";
                        break;
                    case "Decimetro":
                        resultado = valor * 10000;
                        cadena = resultado.ToString() + " dm";
                        break;
                    case "Centimetro":
                        resultado = valor * 100000;
                        cadena = resultado.ToString() + " cm";
                        break;

                }
                break;
    }
        return cadena;
    }

}
