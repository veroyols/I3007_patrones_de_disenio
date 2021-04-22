/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 17/4/2021
 * Hora: 14:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica1
{
	public class Persona : Comparable
	{
		private string nombre;
		private int dni;
		
		public Persona(string nombre, int dni) {
			this.nombre = nombre;
			this.dni = dni;
		}
		
		public Persona(int dni) {
			this.dni = dni;
		}
		
		public Persona() { }		
		
		public string getNombre {
			get { return nombre;}
			set { value = nombre;}
		}
		
		public int getDni {
			get { return dni;}
			set { dni = value;}
		}
		
		//metodos de interfaz comparable
		public bool sosIgual(Comparable objeto) { //para override en Alumnos
			bool igual = false;
			if (dni == ((Persona)objeto).getDni) {
				igual = true;
			}
			return igual;
		}		
		public bool sosMenor(Comparable objeto) {
			bool menor = false;
			if (dni < ((Persona)objeto).getDni) {
				menor = true;
			}
			return menor;
		}

		public bool sosMayor(Comparable objeto) {
			bool mayor = false;
			if (dni > ((Persona)objeto).getDni) {
				mayor = true;
			}
			return mayor;
		}
		
		public static void compararPorConsola (Coleccionable<Comparable> coleccionable) { //EJERCICIO13
			Console.Write("Ingrese DNI para verificar si esta en la coleccion>> ");
			int dni = int.Parse(Console.ReadLine());
			Comparable comparable = new Persona (dni);
			if (coleccionable.contiene(comparable)) {
				Console.WriteLine("El DNI está en la colección");
				Console.WriteLine("--------FIN-INFORME--------\n");
				return;
			}
			Console.WriteLine("El elemento leído NO está en la colección");
			Console.WriteLine("--------FIN-INFORME--------\n");	
		}
		
		public override string ToString() {
			return string.Format(">> Persona Nombre = {0}	DNI = {1}", nombre, dni);
		}


	}
}
