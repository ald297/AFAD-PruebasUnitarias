# Guía Práctica 1: Pruebas Unitarias con MSTest y xUnit (.NET)

**Estudiante:** Alex Fernando Alfaro Diaz  
**Iniciales:** AFAD  
**Docente:** Gerber Alexis Gómez Hidalgo  
**Tecnologías:** .NET SDK, C#, MSTest, xUnit, Azure DevOps, Git / GitHub  

---

## 📋 Descripción de la Solución

Solución desarrollada bajo la nomenclatura requerida **`AFAD`**, que contiene dos proyectos de bibliotecas de clases y sus correspondientes proyectos de pruebas unitarias automatizadas:

```text
AFAD.sln
│
├── AFAD.Temperatura/
│   ├── TemperatureConverter.cs           --> Lógica de conversión de temperatura
│   └── AFAD.Temperatura.csproj
│
├── AFAD.Temperatura.UnitTestMSTest/
│   ├── TemperatureConverterTests.cs      --> Pruebas unitarias con MSTest
│   └── AFAD.Temperatura.UnitTestMSTest.csproj
│
├── AFAD.Cadenas/
│   ├── StringManipulator.cs              --> Lógica de manipulación de cadenas
│   └── AFAD.Cadenas.csproj
│
└── AFAD.Cadenas.UnitTestAppxUnit/
    ├── StringManipulatorTests.cs         --> Pruebas unitarias con xUnit
    └── AFAD.Cadenas.UnitTestAppxUnit.csproj
```

---

## 🧪 Ejercicio 1: Convertidor de Temperatura (MSTest)

- **Proyecto:** `AFAD.Temperatura`
- **Proyecto de Pruebas:** `AFAD.Temperatura.UnitTestMSTest`
- **Framework:** MSTest (`Microsoft.VisualStudio.TestTools.UnitTesting`)
- **Clase:** `TemperatureConverter`
  - `CelsiusToFahrenheit(double celsius)`
  - `FahrenheitToCelsius(double fahrenheit)`
- **Pruebas implementadas:**
  - Punto de congelación ($0^\circ C \leftrightarrow 32^\circ F$)
  - Punto de ebullición ($100^\circ C \leftrightarrow 212^\circ F$)
  - Punto de coincidencia de escalas ($-40^\circ C \leftrightarrow -40^\circ F$)

---

## 🔤 Ejercicio 2: Manipulación de Cadenas (xUnit)

- **Proyecto:** `AFAD.Cadenas`
- **Proyecto de Pruebas:** `AFAD.Cadenas.UnitTestAppxUnit`
- **Framework:** xUnit (`Xunit`)
- **Clase:** `StringManipulator`
  - `ReverseString(string input)`
  - `RemoveSpaces(string input)`
- **Pruebas implementadas:**
  - Inversión de cadenas normales, palíndromos y cadenas vacías.
  - Eliminación de espacios intermedios y consecutivos.
  - Control y aserción de excepciones (`ArgumentNullException`) ante entradas nulas mediante `Assert.Throws`.

---

## ⚙️ Compilación y Ejecución de Pruebas

Para ejecutar la totalidad de pruebas unitarias en la solución:

```bash
dotnet test AFAD.sln
```

### Resultados de la suite de pruebas:
- **`AFAD.Temperatura.UnitTestMSTest`:** 7 pruebas superadas, 0 errores.
- **`AFAD.Cadenas.UnitTestAppxUnit`:** 7 pruebas superadas, 0 errores.
- **Total:** 14 pruebas pasando con éxito (100% verde).

---

## ☁️ Documentación en Azure DevOps

Los 13 casos de prueba correspondientes a ambos ejercicios se encuentran formalmente registrados y documentados en Azure DevOps:
- **Organización:** `lalafaro6`
- **Proyecto:** [AFAD-PruebasUnitarias](https://dev.azure.com/lalafaro6/AFAD-PruebasUnitarias)
- **Work Items (Test Cases):** [Ver Casos de Prueba en Azure DevOps](https://dev.azure.com/lalafaro6/AFAD-PruebasUnitarias/_workitems/recentlyupdated/)
