using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string UnidadMedida { get; set; }
    public string Tipo { get; set; }

    public Producto( string nombre, decimal precio, string unidadMedida, string tipo)
    {
        Nombre = nombre;
        Precio = precio;
        UnidadMedida = unidadMedida;
        Tipo = tipo;
    }

    public Producto(int id, string nombre, decimal precio, string unidadMedida, string tipo)
    {
        Id= id;
        Nombre = nombre;
        Precio = precio;
        UnidadMedida = unidadMedida;
        Tipo = tipo;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Nombre}, Precio: {Precio}, UnidadMedida: {UnidadMedida}, Tipo: {Tipo}";
    }

}

