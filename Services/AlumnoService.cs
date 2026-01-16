using System;
using System.Collections.Generic;
using System.Linq;
using POO.Models;
using POO.Services.Interfaces;

namespace POO.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly List<Alumno> _alumnos = new();

        public void RegisterAlumno(Alumno alumno)
        {
            if (alumno == null)
                throw new ArgumentNullException(nameof(alumno));

            if (_alumnos.Any(a => a.Codigo == alumno.Codigo))
                throw new InvalidOperationException("Ya existe un alumno con ese código.");

            _alumnos.Add(alumno);
        }

        public Alumno ObtenerPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código es obligatorio.");

            var alumno = _alumnos.FirstOrDefault(a => a.Codigo == codigo);

            if (alumno == null)
                throw new InvalidOperationException("Alumno no encontrado.");

            return alumno;
        }

        public IEnumerable<Alumno> ObtenerTodos()
        {
            return _alumnos;
        }

        public void DesactivarAlumno(string codigo)
        {
            var alumno = ObtenerPorCodigo(codigo);

            if (!alumno.Activo)
                throw new InvalidOperationException("El alumno ya está desactivado.");

            alumno.Desactivar();
        }
    }
}
