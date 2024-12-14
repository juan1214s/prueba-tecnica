# Prueba Técnica - Juan Manuel Sánchez

Este es un proyecto de prueba técnica creado por **Juan Manuel Sánchez**. El objetivo del proyecto es desarrollar una API que gestione usuarios, incluyendo su creación y almacenamiento. Esta API está construida utilizando C# y ASP.NET Core, y simula la creación de usuarios con un sistema de generación de IDs automáticos. 

## Funcionalidades

- **Crear usuarios**: Los usuarios pueden ser creados con un nombre y un número de teléfono.
- **Generación automática de IDs**: El ID de cada usuario es generado automáticamente.
- **Validación de datos**: El nombre y el teléfono son campos obligatorios.

## Tecnologías Utilizadas

- **ASP.NET Core**: Framework para construir la API.
- **C#**: Lenguaje de programación utilizado.
- **In-Memory Database (simulada)**: Simulación de una base de datos utilizando una lista en memoria (sin usar un sistema de base de datos real).

## Instalación

### Prerrequisitos

Asegúrate de tener las siguientes herramientas instaladas en tu sistema:

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet) o superior.
- Un editor de texto como [Visual Studio Code](https://code.visualstudio.com/) o [Visual Studio](https://visualstudio.microsoft.com/).

### Pasos para la instalación

1. Clona este repositorio a tu máquina local:
   git clone https://github.com/juan1214s/prueba-tecnica.git
   
2. Abre tu editor favorito

3. Restaura las dependencias "dotnet restore"

4. Compila y ejecuta la API "dotnet run"

Para crear un nuevo usuario esta es la estructura 
{
  "name": "Juan",
  "phone": "123456789"
}
