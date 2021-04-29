/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 18/4/2021
 * Hora: 16:32
 * 
*/
using System;

namespace Practica2
{
	public class Alumno : Persona { 
		private int legajo;
		private double promedio;
		private estrategiaDeComparacion estrategia;
		
		//get - set
		public int getLegajo {
			get { return legajo;}
			set { legajo = value;}
		} 
		public double getPromedio {
			get { return promedio;}
			set { promedio = value;}
		}	
		public estrategiaDeComparacion getEstrategia {
			get { return estrategia; }
			set { estrategia = value;}
		}

		public Alumno() {}
		
		public Alumno(string n , int d, int l, double p) : base (n,d) {
			this.legajo = l;
			this.promedio = p;
		}
	
		public Alumno(string n , int d, int l, double p, estrategiaDeComparacion e) : base (n,d) {
			this.legajo = l;
			this.promedio = p;
			this.getEstrategia = e;
		}
		
		/*EJERCICIO1*/
		public override bool sosIgual(Comparable objeto) { 
			return estrategia.sosIgual(objeto, this);
		}

		public override bool sosMenor(Comparable objeto) { 
			return estrategia.sosMenor(objeto, this);
		}

		public override bool sosMayor(Comparable objeto) { 
			return estrategia.sosMayor(objeto, this);
		}

		public override void compararPorConsola (Coleccionable<Comparable> coleccionable) { 
			Console.WriteLine("Comparar por: \n1.Nombre \n2.Dni \n3.Legajo \n4.Promedio");
			int opcion = int.Parse(Console.ReadLine());
			switch (opcion) {
				case 1:
					getEstrategia = new PorNombre();
					Console.WriteLine("Ingrese nombre del alumno: ");
					getNombre = Console.ReadLine();
					if (coleccionable.contiene(this)) {
							Console.WriteLine("El alumno {0} se encuentra en la {1}",getNombre,coleccionable.ToString());
							break;
						}
					Console.WriteLine("El alumno {0} NO se encuentra en la {1}",getNombre,coleccionable.ToString());
		
					break;
				default:
					Console.WriteLine("--------FIN-INFORME--------\n");	
					break;
			}
		}
		
		public override string ToString() {
			return string.Format(">> Legajo N{0} - Alumnx = {1}	DNI {2} (Promedio = {3})", legajo, getNombre, getDni, promedio);
		}
	}		
}
