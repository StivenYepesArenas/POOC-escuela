using Microsoft.VisualBasic;
using POO.Models;
namespace POO.Services.Interfaces
{
    public interface IAlumnoService
    {
        void Register(Alumno alumno);
        Alumno GetByCode(string codigo);
        IEnumerable<Alumno> GetAll();
        void Desactivate(string codigo);
        void Remove(string Codigo);
        void UpdateBasicData(string codigo, string nombre, string apellido, int edad);  

    }
}