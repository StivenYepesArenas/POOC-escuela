namespace POO.Models;

public class Producto
{
    private int _cantidad;
    private double _precio;
    private string _nombre = string.Empty;

    public int Cantidad
    {
        get { return _cantidad; }
        set
        {
            if (value < 0)
            {
                throw new Exception("La cantidad no puede ser menor a cero");
            }
            _cantidad = value;
        }
    }

    public double Precio
    {
        get { return _precio; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor o igual a cero");
            }
            _precio = value;
        }
    }

    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El nombre no puede estar vacio");
            }
            _nombre = value;
        }
    }

    public Producto() { }
    public Producto(int cantidad, double precio, string nombre)
    {
        Cantidad = cantidad;
        Precio = precio;
        Nombre = nombre;
    }



    public double CalcularTotalProducto()
    {
        return Cantidad * Precio;
    }
    
    public void MostrarInformacion()
    {
        Console.WriteLine($"Producto:\n {Nombre}, Cantidad: {Cantidad}, Precio Unitario: {Precio}, Precio Total: {CalcularTotalProducto()}");
    }
    

}