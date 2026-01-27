using POO.Models;
using POO.Repositories.Interfaces;
using POO.Services.Interfaces;

namespace POO.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly IAlumnoRepository _repository;

        public AlumnoService(IAlumnoRepository alumnoRepository)
        {
            _repository = alumnoRepository;
        }
        public void Register(Alumno alumno)
        {
            if (alumno == null)
                throw new ArgumentNullException(nameof(alumno));

            if (_repository.GetByCode(alumno.Codigo) !=null)
                throw new InvalidOperationException("Ya existe un alumno con ese código.");

            _repository.Add(alumno);
        }

        public Alumno GetByCode(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código es obligatorio.");

            var alumno = _repository.GetByCode(codigo);

            if (alumno == null)
                throw new InvalidOperationException("Alumno no encontrado.");

            return alumno;
        }

        public IEnumerable<Alumno> GetAll()
        {
            return _repository.GetAll();
        }

        public void Desactivate(string codigo)
        {
            var alumno = GetByCode(codigo);

            if (!alumno.Activo)
                throw new InvalidOperationException("El alumno ya está desactivado.");

            alumno.Desactivar();
        }
    }
}
