using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RadioButtonSex : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string GetValorRadio()
    {
        return rbSex.SelectedValue;
    }

    public void SetValorRadio(string valor)
    {
        rbSex.SelectedValue = valor;
    }
}