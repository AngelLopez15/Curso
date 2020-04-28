using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Curso;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Registro registro = new Registro();
        Persona entidad = registro.Obtener(1);

        ltrnombre.Text = entidad.Nombre + " " + entidad.Apellidos;
        lblnombre.Text = entidad.Email;
        txtedad.Text = entidad.Edad.ToString();

        //entidad.Nombre = ltrnombre.Text;
        //registro.Guardar(entidad);
    }
}