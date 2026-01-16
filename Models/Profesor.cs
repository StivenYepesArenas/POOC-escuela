namespace POO.Models;

public class Profesor : Persona
{
    public string Codigo { get; private set; }
    public string Materia { get; private set; }
    public bool Activo { get; private set; }

    public Profesor(
        string codigo,
        string nombre,
        string apellido,
        int edad,
        string materia
    ) : base(nombre, apellido, edad)
    {
        if (string.IsNullOrWhiteSpace(codigo))
            throw new ArgumentException("El código es obligatorio.");

        Codigo = codigo;
        Materia = materia;
        Activo = true;
    }
    public void Desactivar()
    {
        Activo = false;
    }


}