﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session_resumen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        nombre.Text = Session["nombre"].ToString();
        apellido.Text = Session["apellido"].ToString();
        dni.Text = Session["dni"].ToString();
        domicilio.Text = Session["domicilio"].ToString();
        nacionalidad.Text = Session["nacionalidad"].ToString();
        sexo.Text = Session["sexo"].ToString();
        fecha.Text = Session["fecha"].ToString();
        estudio.Text = Session["nivel"].ToString();
        titulo.Text = Session["titulo"].ToString();
        establecimiento.Text = Session["establecimiento"].ToString();
        periodoDesde.Text = Session["fecDesde"].ToString();
        periodoHasta.Text = Session["fecHasta"].ToString();
        lugar.Text = Session["lugar"].ToString();
        tarea.Text = Session["tarea"].ToString();
        idioma.Text = Session["idioma"].ToString();
        nivel.Text = Session["nivelIdioma"].ToString();

    }
}