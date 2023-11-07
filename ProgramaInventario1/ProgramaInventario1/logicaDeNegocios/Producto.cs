using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Producto
{
<<<<<<< HEAD
    internal class Producto
=======
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string UnidadMedida { get; set; }
    public string Tipo { get; set; }

    public Producto( string nombre, decimal precio, string unidadMedida, string tipo)
>>>>>>> Prueba
    {
        Nombre = nombre;
        Precio = precio;
        UnidadMedida = unidadMedida;
        Tipo = tipo;
    }
<<<<<<< HEAD
=======

    public Producto(int id, string nombre, decimal precio, string unidadMedida, string tipo)
    {
        Id= id;
        Nombre = nombre;
        Precio = precio;
        UnidadMedida = unidadMedida;
        Tipo = tipo;
    }

>>>>>>> Prueba
}

