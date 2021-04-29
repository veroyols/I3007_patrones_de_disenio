/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 20:39
 */
using System;

namespace Practica2
{
	public class Numero : Comparable { 
		private int valor;
		
		public Numero(int v) { 
			this.valor = v;
		}
		
		public Numero() {}
		
		public int getValor { //declara la propiedad publica
			get {return valor; }
		}

		public bool sosIgual(Comparable objeto) { //verdadero si el objeto es el mismo que el parámetro
			bool igual = false;
			if (valor == ((Numero)objeto).getValor) {
				igual = true;
			}
			return igual;
		}

		public bool sosMenor(Comparable objeto) { //verdadero si el objeto es menor que el parámetro
			bool menor = false;
			if (valor < ((Numero)objeto).getValor) {
				menor = true;
			}
			return menor;
		}

		public bool sosMayor(Comparable objeto) { //verdadero si el objeto es mayor que el parámetro
			bool mayor = false;
			if (valor > ((Numero)objeto).getValor) {
				mayor = true;
			}
			return mayor;
		}

		public void compararPorConsola (Coleccionable<Comparable> coleccionable) {
			Console.Write("Ingrese un Valor >> ");
			int a = int.Parse(Console.ReadLine());
			if (coleccionable.contiene(new Numero(a) )) {
				Console.WriteLine("El elemento {0} pertenece a la {1}",a,coleccionable.ToString());
				Console.WriteLine("--------FIN-INFORME--------\n");
				return;
			}
			Console.WriteLine("El elemento {0} NO pertenece a la {1}.",a,coleccionable.ToString());
			Console.WriteLine("--------FIN-INFORME--------\n");	
		}
		
		public override string ToString() {
			return string.Format(">> Numero Valor = {0}", valor);
		}	
	}
}
