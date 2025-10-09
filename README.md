# 🧠 Proyecto de Programación Orientada a Objetos en C#

Este proyecto es una simulación de una pequeña escuela, desarrollada para practicar los fundamentos de **Programación Orientada a Objetos (POO)** en el lenguaje **C#**.  
El objetivo es demostrar el uso de **clases, herencia, encapsulamiento, polimorfismo y validaciones**, aplicados a un escenario educativo con **Personas, Alumnos, Profesores y un Director**.

---

## 🎯 Objetivo del proyecto

Este ejercicio fue creado para reforzar los **principios básicos de la POO**, aplicados de manera práctica:

- ✅ **Clases y objetos:** definición y creación de entidades.
- ✅ **Encapsulamiento:** control de acceso con modificadores (`private`, `public`, `protected`).
- ✅ **Constructores:** inicialización de objetos.
- ✅ **Herencia:** creación de clases derivadas a partir de una base común.
- ✅ **Polimorfismo:** comportamiento diferente de un mismo método según el tipo de objeto.
- ✅ **Sobrescritura de métodos (`override`):** redefinición del método `Presentarse()` en las clases hijas.
- ✅ **Listas genéricas (`List<T>`):** almacenamiento de distintos tipos de objetos derivados de una misma clase base.
- ✅ **Manejo de excepciones:** validación y control de errores con `try-catch`.

---

## 🧱 Estructura del proyecto

POO-Escuela/
├── Program.cs
├── Models/
│ ├── Personas.cs
│ ├── Alumno.cs
│ ├── Profesor.cs
│ └── Director.cs
└── README.md


## 💻 Ejecución del programa

Para ejecutar este proyecto desde Visual Studio Code o terminal:

```bash
dotnet run

⚙️ Conceptos aplicados
Concepto	Descripción
Encapsulamiento	Los atributos están protegidos mediante campos privados y propiedades públicas.
Herencia	Alumno, Profesor y Director heredan de Personas.
Polimorfismo	El método Presentarse() se comporta distinto según el tipo de objeto.
Sobrescritura (override)	Permite redefinir el comportamiento de un método heredado.
Validaciones	Se evitan datos vacíos o inválidos mediante condiciones en los set.
Listas (List<T>)	Se utiliza una lista genérica para almacenar diferentes tipos de personas.

👨‍💻 Autor

Desarrollado por: Estiven Yepes
📚 Proyecto académico para reforzar fundamentos de C# y Programación Orientada a Objetos.
💡 "El mejor código no solo funciona, también enseña."