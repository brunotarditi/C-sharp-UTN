using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Ejercicio2 : System.Web.UI.Page
{
    Gestor gc = new Gestor();
    protected void Validaciones(object sender, EventArgs e)
    {

        string fecha = day.Text + "-" + month.Text + "-" + year.Text;
        string contrasenia = SHA1(password.Text);

        if (Page.IsValid)
        {
            gc.guardar(firstname.Text, lastname.Text, email.Text, contrasenia, fecha, sex.SelectedValue, phone.Text, emailAlternative.Text, country.SelectedValue);
            Response.Redirect("Siguiente.aspx");
            
        }
       
    }

    protected void ValidaCbx(object sender, ServerValidateEventArgs args)
    {
        args.IsValid = cbx.Checked;
    }

    string SHA1(string s)
    {
        SHA1 sha1 = SHA1Managed.Create();
        ASCIIEncoding encoding = new ASCIIEncoding();
        byte[] stream = null;
        StringBuilder sb = new StringBuilder();
        stream = sha1.ComputeHash(encoding.GetBytes(s));
        for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
        return sb.ToString();
    }

}