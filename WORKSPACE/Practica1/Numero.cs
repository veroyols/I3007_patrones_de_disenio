/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 14/4/2021
 * Hora: 20:39
 * 
Ejercicio 2
Nota: Si se implementa en C#, en los tres métodos a implementar, se deberá castear el parámetro recibido a Numero.
 */
using System;

namespace Practica1
{
	public class Numero : Comparable { //Haga que la clase Numero implemente la interface Comparable
		private int valor;
		
		public Numero(int v) { //constructor(v)
			this.valor = v;
		}
		
		public Numero() { //constructor()
		}
		
		public int getValor { //declara la propiedad publica
			get {return valor; }
		}

//verdadero si el objeto que recibe el mensaje es el mismo que el “comparable” por parámetro, falso en caso contrario
		public bool sosIgual(Comparable objeto) {
			bool igual = false;
			if (valor == ((Numero)objeto).getValor) {
				igual = true;
			}
			return igual;
		}

//verdadero si el objeto que recibe el mensaje es menor que el “comparable” por parámetro, falso en caso contrario	
		public bool sosMenor(Comparable objeto) {
			bool menor = false;
			if (valor < ((Numero)objeto).getValor) {
				menor = true;
			}
			return menor;
		}

//verdadero si el objeto que recibe el mensaje es mayor que el “comparable” por parámetro, falso en caso contrario
		public bool sosMayor(Comparable objeto) {
			bool mayor = false;
			if (valor > ((Numero)objeto).getValor) {
				mayor = true;
			}
			return mayor;
		}

		public void compararPorConsola (Coleccionable<Comparable> coleccionable) { //EJERCICIO6
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
