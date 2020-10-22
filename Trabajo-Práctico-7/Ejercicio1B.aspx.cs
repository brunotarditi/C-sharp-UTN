using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ejercicio1B : System.Web.UI.Page
{
    protected void DatosIngresadosASP(object sender, EventArgs e)
    {
        //CAJA DE TEXTO
        caja.Text = txtCaja.Text;

        //COMBO BOX
        for (int i = 0; i < combo.Items.Count; i++)
        {
            cbo.Text = combo.SelectedValue;
        }
        //IMAGEN
        imagen.Text = img.ImageUrl;

        //CHECKBOX
        for (int i = 0; i < cbx.Items.Count; i++)
        {
            if ((cbx.Items[0].Selected && cbx.Items[1].Selected) || (!cbx.Items[0].Selected && !cbx.Items[1].Selected))
            {
                cbox.Text = "Debe seleccionar 1";
                
            }
            else
            {
                if (cbx.Items[0].Selected)
                {
                    cbox.Text = cbx.SelectedValue;
                }
                else
                {
                    cbox.Text = cbx.SelectedValue;
                }
                
            }
            
        }

        //HIPERVINCULO

        hyp.Text = link.NavigateUrl;

        //RADIO BUTTON

        for (int i = 0; i < radio.Items.Count; i++)
        {
            if (radio.Items[i].Selected)
            {
                rbtn.Text = radio.SelectedValue;
            }
        }

        //CAMPO OCULTO

        campo.Text = hdn.Value;

    }
}