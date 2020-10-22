using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ejercicio1A : System.Web.UI.Page
{
    protected void DatosIngresadosHTML(object sender, EventArgs e)
    {

        //CAJA DE TEXTO
        rqtxtCaja.InnerText = txtCaja.Value;

        //COMBO BOX
        for (int i = 0; i < combo.Items.Count; i++)
        {
            if (combo.Items[i].Selected)
            {
                rqCombo.InnerText = combo.Items[i].Value;
            }
        }

        //IMAGEN
        rqImg.InnerText = img.Alt + " " + img.Src;

        //CHECKBOX
        if ((cbx1.Checked && cbx2.Checked) || (!cbx1.Checked && !cbx2.Checked))
        {
            rqCbx.InnerText = "Debe seleccionar 1.";
        }
        else
        {
            if (cbx1.Checked)
            {
                rqCbx.InnerText = cbx1.Value;
            }
            else
            {
                rqCbx.InnerText = cbx2.Value;
            }

        }

        //HIPERVINCULO
        rqHyper.InnerText = link.HRef;

        //RADIO BUTTON

        if (rb1.Checked)
        {
            rqRadio.InnerText = rb1.Value;
        }
        else if (rb2.Checked)
        {
            rqRadio.InnerText = rb2.Value;
        }
        else
        {
            rqRadio.InnerText = rb3.Value;
        }

        //CAMPO OCULTO
        rqHdn.InnerText = hdn.Value;

    }
}