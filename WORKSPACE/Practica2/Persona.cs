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

namespace Practica2 {
	
	public class Persona : Comparable {
		
		protected string nombre;
		protected int dni;
		
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
			set { nombre = value;}
		}
		
		public int getDni {
			get { return dni;}
			set { dni = value;}
		}
		
		public virtual bool sosIgual(Comparable objeto) { //por nombre o dni
			bool igual = false;
			if ((nombre == ((Persona)objeto).getNombre ) || (dni == ((Persona)objeto).getDni)){
				igual = true;
			}
			return igual;
		}		
		public virtual bool sosMenor(Comparable objeto) {
			bool menor = false;
			if (dni < ((Persona)objeto).getDni) {
				menor = true;
			}
			return menor;
		}
		public virtual bool sosMayor(Comparable objeto) {
			bool mayor = false;
			if (dni > ((Persona)objeto).getDni) {
				mayor = true;
			}
			return mayor;
		}
		
		public virtual void compararPorConsola (Coleccionable<Comparable> coleccionable) { 
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
