using POO.Models;
using POO.Repositories.Interfaces;
namespace POO.Repositories
{
    public class AlumnoRepositoryInMemory : IAlumnoRepository
    {
        private readonly List<Alumno> _alumnos = new();
        public void Add(Alumno alumno)
        {
            _alumnos.Add(alumno);
        }

        public Alumno? GetByCode(string codigo)
        {
            return _alumnos.FirstOrDefault(a => a.Codigo == codigo);
        }

        public IEnumerable<Alumno> GetAll()
        {
            return _alumnos;
        }

        public void Update(Alumno alumno)
        {
            var index = _alumnos.FindIndex(a => a.Codigo == alumno.Codigo);
            if (index != -1)
                _alumnos[index] = alumno;
        }

        public void Remove(string codigo)
        {
            var alumno = _alumnos.FirstOrDefault(a => a.Codigo == codigo);
            if (alumno != null)
                _alumnos.Remove(alumno);
        }
    }
}