using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AppWebService : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Servicio.ConvertSoapClient ws = new Servicio.ConvertSoapClient();
        try {
            string longitud = ws.Convertir(longitudA.SelectedValue, longitudB.SelectedValue, Convert.ToDouble(valor.Text));
            resultado.Text = longitud;
        } catch (FormatException ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }
    }
 
}