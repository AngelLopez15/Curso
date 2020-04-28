using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Threading;

/// <summary>
/// Descripción breve de swpersona
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
[System.Web.Script.Services.ScriptService]
public class swpersona : System.Web.Services.WebService
{

    public swpersona()
    {
        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public bool Guardarsw(Persona propiedad)
    {
        bool exitoso = true;

        try
        {
            new Registro().Guardar(propiedad);
            exitoso = true;
        }
        catch(Exception ex)
        {
            exitoso = false;
        }

        //Thread.Sleep(3000);
        return exitoso;
        //return "Hola " + propiedad.Nombre + " " + propiedad.Apellidos;
    }

}
