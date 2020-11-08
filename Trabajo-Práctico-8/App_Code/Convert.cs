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
        double resultado;
        switch (a)
        {
            case "Kilometro":
                
                switch (b)
                {
                    case "Kilometro":
                        resultado = valor;
                        cadena = resultado.ToString() + " km";
                        break;

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

                    case "Milimetro":
                        resultado = valor * 1000000;
                        cadena = resultado.ToString() + " mm";
                        break;

                    case "Micrometro":
                        resultado = valor * 1000000000;
                        cadena = resultado.ToString() + " µm";
                        break;

                }
                break;

            case "Metro":

                switch (b)
                {
                    case "Kilometro":
                        resultado = valor / 1000;
                        cadena = resultado.ToString() + " km";
                        break;

                    case "Metro":
                        resultado = valor;
                        cadena = resultado.ToString() + " m";
                        break;

                    case "Decimetro":
                        resultado = valor * 10;
                        cadena = resultado.ToString() + " dm";
                        break;
                    case "Centimetro":
                        resultado = valor * 100;
                        cadena = resultado.ToString() + " cm";
                        break;
                    case "Milimetro":
                        resultado = valor * 1000;
                        cadena = resultado.ToString() + " mm";
                        break;
                    case "Micrometro":
                        resultado = valor * 1000000;
                        cadena = resultado.ToString() + " µm";
                        break;

                }
                break;

            case "Decimetro":

                switch (b)
                {
                    case "Kilometro":
                        resultado = valor / 10000;
                        cadena = resultado.ToString() + " km";
                        break;

                    case "Metro":
                        resultado = valor / 10;
                        cadena = resultado.ToString() + " m";
                        break;

                    case "Decimetro":
                        resultado = valor;
                        cadena = resultado.ToString() + " dm";
                        break;
                    case "Centimetro":
                        resultado = valor * 10;
                        cadena = resultado.ToString() + " cm";
                        break;
                    case "Milimetro":
                        resultado = valor * 100;
                        cadena = resultado.ToString() + " mm";
                        break;
                    case "Micrometro":
                        resultado = valor * 100000;
                        cadena = resultado.ToString() + " µm";
                        break;

                }
                break;

            case "Centimetro":

                switch (b)
                {
                    case "Kilometro":
                        resultado = valor / 100000;
                        cadena = resultado.ToString() + " km";
                        break;

                    case "Metro":
                        resultado = valor / 100;
                        cadena = resultado.ToString() + " m";
                        break;

                    case "Decimetro":
                        resultado = valor / 10;
                        cadena = resultado.ToString() + " dm";
                        break;
                    case "Centimetro":
                        resultado = valor;
                        cadena = resultado.ToString() + " cm";
                        break;
                    case "Milimetro":
                        resultado = valor * 10;
                        cadena = resultado.ToString() + " mm";
                        break;
                    case "Micrometro":
                        resultado = valor * 10000;
                        cadena = resultado.ToString() + " µm";
                        break;

                }
                break;

            case "Milimetro":

                switch (b)
                {
                    case "Kilometro":
                        resultado = valor / 1000000;
                        cadena = resultado.ToString() + " km";
                        break;

                    case "Metro":
                        resultado = valor / 1000;
                        cadena = resultado.ToString() + " m";
                        break;

                    case "Decimetro":
                        resultado = valor / 100;
                        cadena = resultado.ToString() + " dm";
                        break;
                    case "Centimetro":
                        resultado = valor / 10;
                        cadena = resultado.ToString() + " cm";
                        break;
                    case "Milimetro":
                        resultado = valor;
                        cadena = resultado.ToString() + " mm";
                        break;
                    case "Micrometro":
                        resultado = valor * 1000000000;
                        cadena = resultado.ToString() + " µm";
                        break;

                }
                break;

            case "Micrometro":

                switch (b)
                {
                    case "Micrometro":
                        resultado = valor;
                        cadena = resultado.ToString() + " µm";
                        break;

                    case "Milimetro":
                        resultado = valor / 1000;
                        cadena = resultado.ToString() + " mm";
                        break;

                    case "Centimetro":
                        resultado = valor / 10000;
                        cadena = resultado.ToString() + " cm";
                        break;

                    case "Decimetro":
                        resultado = valor / 100000;
                        cadena = resultado.ToString() + " dm";
                        break;
                    
                    case "Metro":
                        resultado = valor / 1000000;
                        cadena = resultado.ToString() + " m";
                        break;

                    case "Kilometro":
                        resultado = valor / 1000000000;
                        cadena = resultado.ToString() + " km";
                        break;

                }
                break;
        }
        return cadena;
    }

}
