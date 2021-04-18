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
		}
		public int getDni {
			get { return dni;}
		}
		
		//metodos de interfaz comparable
		public bool sosIgual(Comparable objeto) {
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

		public static void informar (Coleccionable coleccionable) { //EJERCICIO13
			Console.WriteLine("----------INFORME----------");
			Console.WriteLine("La coleccion posee {0} elementos.",coleccionable.cuantos());
			Console.WriteLine("Valor minimo >> " + ((Persona)coleccionable.minimo()).dni);
			Console.WriteLine("Valor maximo >> " + ((Persona)coleccionable.maximo()).dni);
			Console.Write("Ingrese numero para verificar si esta en la coleccion>> ");
			int a = int.Parse(Console.ReadLine());
			Comparable comparable = new Persona (a);
			if (coleccionable.contiene(comparable)) {
				Console.WriteLine("El elemento leído está en la colección");
				Console.WriteLine("--------FIN-INFORME--------\n");
				return;
			}
			Console.WriteLine("El elemento leído NO está en la colección");
			Console.WriteLine("--------FIN-INFORME--------\n");	
		}
		
	}
}
