namespace POO.Models;

public class CuentaBancaria
{
    decimal _saldo;
    public decimal Saldo
    {
        get { return _saldo; }
    }

    public decimal Depositar(decimal monto)
    {
        if (monto > 0)
        {
            _saldo += monto;
        }
        return _saldo;
    }
    public decimal Retirar(decimal monto)
    {
        if (monto > _saldo)
        {
            throw new ArgumentException("El monto a retirar no puede ser mayor al saldo");
        }
        _saldo -= monto;
        return _saldo;
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"El saldo actual es: {Saldo}");
    }
}