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
		
		public void compararPorConsola (Coleccionable<Comparable> coleccionable) { //EJERCICIO13
			Console.Write("Ingrese DNI >> ");
			int a = int.Parse(Console.ReadLine());			
			if (coleccionable.contiene(new Persona(a))) {
				Console.WriteLine("El DNI N{0} pertenece a la {1}",a,coleccionable.ToString());
				Console.WriteLine("--------FIN-INFORME--------\n");
				return;
			}
			Console.WriteLine("El DNI N{0} NO pertenece a la {1}",a,coleccionable.ToString());
			Console.WriteLine("--------FIN-INFORME--------\n");	
		}
		
		public override string ToString() {
			return string.Format(">> Persona Nombre = {0}	DNI = {1}", nombre, dni);
		}
	}
}
