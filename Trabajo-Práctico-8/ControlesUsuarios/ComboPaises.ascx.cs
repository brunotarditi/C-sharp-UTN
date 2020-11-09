using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ComboPaises : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string GetValorCombo()
    {
        return cbx.SelectedValue;
    }

    public void SetValorCombo(string valor)
    {
        cbx.SelectedValue = valor;
    }
}