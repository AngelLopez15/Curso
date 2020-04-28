using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Configuration;

/// <summary>
/// Clase de datos para el registro
/// </summary>
public class Registro
{
    public Registro() {}

    /// <summary>
    /// Obtener datos de la persona
    /// </summary>
    /// <param name="Id">Parametro Id de la persona</param>
    public Persona Obtener(int Id)
    {
        Persona entidad = new Persona();
        string cadena = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        SqlConnection conn = new SqlConnection(cadena);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "SELECT * FROM REGISTRO WHERE ID = @id";
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;

        try
        {
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                entidad.Id = Id;
                entidad.Nombre = dr["NOMBRE"].ToString();
                entidad.Apellidos = dr["APELLIDOS"].ToString();
                entidad.Email = dr["EMAIL"].ToString();
                entidad.Edad = Convert.ToInt32(dr["EDAD"]);
            }

            dr.Close();

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            cmd.Dispose();
            conn.Dispose();
        }

        return entidad;
    }


    /// <summary>
    /// guardar datos de la persona
    /// </summary>
    /// <param name="entidad">Entidad Persona</param>
    public void Guardar(Persona entidad)
    {
        string cadena = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        SqlConnection conn = new SqlConnection(cadena);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "INSERT INTO [dbo].[REGISTRO]([NOMBRE],[APELLIDOS],[EMAIL],[EDAD]) VALUES(@nombre,@apellidos,@email,@edad)";
        cmd.Parameters.Add("@nombre",    SqlDbType.VarChar, 50).Value = entidad.Nombre;
        cmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = entidad.Apellidos;
        cmd.Parameters.Add("@email",     SqlDbType.VarChar, 100).Value = String.IsNullOrEmpty(entidad.Email) ? SqlString.Null : entidad.Email;
        cmd.Parameters.Add("@edad",      SqlDbType.Int).Value = entidad.Edad;

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            cmd.Dispose();
            conn.Dispose();
        }

    }

}