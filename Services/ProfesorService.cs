using System;
using System.Collections.Generic;
using System.Linq;
using POO.Models;
using POO.Services.Interfaces;

namespace POO.Services
{
    public class ProfesorService : IProfesorService
    {
        private readonly List<Profesor> _profesores = new();

        public void RegisterProfesor(Profesor profesor)
        {
            if (profesor == null)
                throw new ArgumentNullException(nameof(profesor));

            if (_profesores.Any(p => p.Codigo == profesor.Codigo))
                throw new InvalidOperationException("Ya existe un profesor con ese código.");

            _profesores.Add(profesor);
        }
        public Profesor ObtenerPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código es obligatorio.");

            var profesor = _profesores.FirstOrDefault(p => p.Codigo == codigo);

            if (profesor == null)
                throw new InvalidOperationException("Profesor no encontrado.");

            return profesor;
        }
        public IEnumerable<Profesor> ObtenerTodos()
        {
            return _profesores;
        }

        public void DesactivarProfesor(string codigo)
        {
            var profesor = ObtenerPorCodigo(codigo);

            if (!profesor.Activo)
                throw new InvalidOperationException("El profesor ya está desactivado.");

            profesor.Desactivar();
        }
    }
}
