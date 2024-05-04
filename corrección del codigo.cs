﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Arreglar_el_Programa
{
    internal class Program
    {
        static List<Empleado> empleados = new List<Empleado>();

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n1. Agregar empleado");
                Console.WriteLine("2. Listar empleados");
                Console.WriteLine("3. Calcular salario total");
                Console.WriteLine("4. Guardar datos");
                Console.WriteLine("5. Cargar datos");
                Console.WriteLine("6. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEmpleado();
                        break;
                    case "2":
                        ListarEmpleados();
                        break;
                    case "3":
                        CalcularSalarioTotal();
                        break;
                    case "4":
                        GuardarDatos();
                        break;
                    case "5":
                        CargarDatos();
                        break;
                    case "6":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }

        static void AgregarEmpleado()
        {
            Console.WriteLine("\nAgregar empleado:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Tipo de empleado (1: Tiempo Completo, 2: Por Horas): ");
            string tipoEmpleado = Console.ReadLine();
            Console.Write("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            if (tipoEmpleado == "1")
            {
                empleados.Add(new EmpleadoTiempoCompleto(nombre, salario));
            }
            else if (tipoEmpleado == "2")
            {
                Console.Write("Horas trabajadas: ");
                int horasTrabajadas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Salario por hora: ");
                double salarioPorHora = Convert.ToDouble(Console.ReadLine());
                empleados.Add(new EmpleadoPorHoras(nombre, salarioPorHora, horasTrabajadas));
            }
            else
            {
                Console.WriteLine("Tipo de empleado no válido.");
            }
        }

        static void ListarEmpleados()
        {
            Console.WriteLine("\nLista de empleados:");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado);
            }
        }

        static void CalcularSalarioTotal()


