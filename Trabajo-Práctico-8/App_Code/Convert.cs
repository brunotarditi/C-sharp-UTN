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
    public string Convertir(string opcion1, string opcion2, double valor)
    {
        double resultado = 0;
        string cadena = "";
        switch (opcion1)
        {
            case "Kilometro":
                resultado = valor;
                break;

            case "Metro":
                resultado = valor / 1000;
                break;

            case "Decimetro":
                resultado = valor / 10000;
                break;

            case "Centimetro":
                resultado = valor / 100000;
                break;

            case "Milimetro":
                resultado = valor / 1000000;
                
                break;

            case "Micrometro":
                resultado = valor / 1000000000;
                break;
        }
        switch (opcion2)
        {
            case "Kilometro":
                resultado += 0;
                cadena = resultado.ToString() + " km";
                break;

            case "Metro":
                resultado *= 1000;
                cadena = resultado.ToString() + " m";
                break;

            case "Decimetro":
                resultado *= 10000;
                cadena = resultado.ToString() + " dm";
                break;

            case "Centimetro":
                resultado *= 100000;
                cadena = resultado.ToString() + " cm";
                break;

            case "Milimetro":
                resultado *= 1000000;
                cadena = resultado.ToString() + " mm";
                break;

            case "Micrometro":
                resultado *= 1000000000;
                cadena = resultado.ToString() + " µm";
                break;
        }
        return cadena;

    }

}
