/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 18/4/2021
 * Hora: 16:32
 * 
*/
using System;

namespace Practica2 {
	
	public class Alumno : Persona { 
		
		private int legajo;
		private double promedio;
		private EstrategiaDeComparacion estrategia;
		
		//get - set
		public int getLegajo {
			get { return legajo;}
			set { legajo = value;}
		} 
		public double getPromedio {
			get { return promedio;}
			set { promedio = value;}
		}	
		public EstrategiaDeComparacion getEstrategia {
			get { return estrategia; }
			set { estrategia = value;}
		}

		public Alumno() {}

		public Alumno(string nombre) {
			this.getNombre = nombre;
		}
		
		public Alumno(string n , int d, int l, double p) : base (n,d) {
			this.legajo = l;
			this.promedio = p;
		}
	
		public Alumno(string n , int d, int l, double p, EstrategiaDeComparacion e) : base (n,d) {
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
			Console.WriteLine(this.ToString());
			Console.WriteLine("Comparar por: \n1.Nombre \n2.Dni \n3.Legajo \n4.Promedio");

			int opcion = int.Parse(Console.ReadLine());
			switch (opcion) {
				case 1:
					this.getEstrategia = new PorNombre();
					//metodo
					if (coleccionable.contiene(this)) {
							Console.WriteLine("El alumno {0} se encuentra en la {1}",this.getNombre,coleccionable.ToString());
							break;
						}
					Console.WriteLine("El alumno {0} NO se encuentra en la {1}",this.getNombre,coleccionable.ToString());
					//metodo
					break;
				case 2:
					this.getEstrategia = new PorDni();
					if (coleccionable.contiene(this)) {
							Console.WriteLine("El DNI {0} se encuentra en la {1}",this.getDni,coleccionable.ToString());
							break;
						}
					Console.WriteLine("El DNI {0} NO se encuentra en la {1}",this.getDni,coleccionable.ToString());
					break;
				case 3:
					this.getEstrategia = new PorLegajo();
					if (coleccionable.contiene(this)) {
							Console.WriteLine("El Legajo N {0} se encuentra en la {1}",this.getLegajo,coleccionable.ToString());
							break;
						}
					Console.WriteLine("El Legajo N {0} NO se encuentra en la {1}",this.getLegajo,coleccionable.ToString());
					break;				
				case 4:
					getEstrategia = new PorPromedio();
					if (coleccionable.contiene(this)) {
							Console.WriteLine("El Promedio N {0} se encuentra en la {1}",this.getPromedio,coleccionable.ToString());
							break;
						}
					Console.WriteLine("El Promedio N {0} NO se encuentra en la {1}",this.getPromedio,coleccionable.ToString());
					break;	
				default:
					Console.WriteLine("--------FIN-INFORME--------\n");	
					break;
			}
		}
		
		public override string ToString() {
			return string.Format(">> Id{0} {1} (DNI {2}) | Nota: {3})", legajo, getNombre, getDni, promedio);
		}
	}		
}
