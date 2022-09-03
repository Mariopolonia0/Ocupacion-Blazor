using Microsoft.EntityFrameworkCore;
using projectoOcupacion.Data;
using projectoOcupacion.Models;

public class OcupacionBll
{

    public async static Task<bool> Guardar(Ocupacion ocupacion)
    {
        Contexto contexto = new Contexto();
        var guardado = false;
        try
        {
            if (Existe(ocupacion.OcupacionId))
                contexto.Update(ocupacion);
            else
                contexto.Add(ocupacion);

            guardado = await contexto.SaveChangesAsync() > 0;
        }
        catch (Exception exception)
        {
            System.Console.Write(exception.ToString());
        }
        return guardado;
    }

    public async static Task<bool> Eliminar(Ocupacion ocupacion)
    {
        Contexto contexto = new Contexto();
        var eliminado = false;
        try
        {
            contexto.Remove(ocupacion);
            eliminado = await contexto.SaveChangesAsync() > 0;
        }
        catch (Exception exception)
        {
            System.Console.Write(exception.ToString());
        }

        return eliminado;
    }

    public async static Task<Ocupacion?> BuscarDescripcion(string descripcion)
    {
        Contexto contexto = new Contexto();
        Ocupacion? ocupacion = new Ocupacion();
        try
        {
            ocupacion = await contexto.ocupaciones!.FirstOrDefaultAsync(o => o.Descripcion == descripcion);
        }
        catch (Exception exception)
        {
            System.Console.Write(exception.ToString());
        }
        return ocupacion;
    }

    public static bool Existe(int ocupacionId)
    {
        Contexto contexto = new Contexto();
        var exite = false;
        try
        {
            exite = contexto.ocupaciones!.Any(ocupacion => ocupacion.OcupacionId == ocupacionId);
        }
        catch (Exception exception)
        {
            System.Console.Write(exception.ToString());
        }
        return exite;
    }
}

// try
// {

// }
// catch (Exception exception)
// {
//     System.Console.Write(exception.ToString());
// }