using POO.Models;
using System;

class Program
{
    static void Main(String[] args)
    {
        /*Alumno alumno = new Alumno();
        Alumno alu1 = new Alumno(32, "Estiven", "Yepes");
        Console.WriteLine(alu1.Nombre);
        Console.WriteLine(alu1.Apellido);
        Console.WriteLine(alu1.Id);

        Persona persona1 = new Persona(27, "Estiven Yepes");
        persona1.Saludar();

        Producto producto1 = new Producto(2, 1500, "Arroz");
        Producto producto2 = new Producto(2, 2000, "Arbeja");
        Producto producto3 = new Producto(2, 3000, "Carne");

        producto1.MostrarInformacion();
        producto2.MostrarInformacion();
        producto3.MostrarInformacion();*/

        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Depositar(10000);
        cuenta.MostrarSaldo();
        cuenta.Retirar(5000);   
        cuenta.MostrarSaldo();

    }
}