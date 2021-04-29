/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 27/4/2021
 * Hora: 22:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica2
{
	class Program
	{
		private static Random unicoRandomGlobal = new Random(); 	

		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Pila pilaAl = new Pila();
			llenarAlumnos(pilaAl);
			Cola colaAl = new Cola();
			llenarAlumnos(colaAl);
			ColeccionMultiple coleccionAl = new ColeccionMultiple (pilaAl,colaAl);
			informarGeneral(coleccionAl);
			
//			estrategiaDeComparacion e = new PorLegajo();
//			Alumno al = new Alumno("Vero",30975596,1984,10,e);
//			Alumno al2 = new Alumno("Juana",50885165,2011,8,e);
//			al.sosMenor(al2); //obj,this
//			Console.WriteLine(al.getLegajo+" es menor que "+al2.getLegajo+"? "+al.sosMenor(al2));
//			Console.WriteLine(al.getLegajo+" es mayor que "+al2.getLegajo+"? "+al.sosMayor(al2));		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		public static void llenarAlumnos(Coleccionable<Comparable> coleccionable){ //EJERCICIO2
			estrategiaDeComparacion estrategia = new PorPromedio();
			List<string> lista = new List<string> (20) {"Luz","Mar","Bea","Ana","Ema","Jua","Ale","Joa","Roy","Noe",
														"Ian","Paz","Sol","Luca","Car","Dem","Enzo","Ve","Gra","Deb",};
			for (int i = 0; i < 20; i++) { //nombre, dni
				coleccionable.agregar(new Alumno (lista[(unicoRandomGlobal.Next(1,99))%20], //nombre
				                                  (unicoRandomGlobal.Next(12000000,50000000)) , //dni
				                                  i+1, //legajo
				                                  ((unicoRandomGlobal.Next(1,1000))/100),// promedio
				                                  estrategia)); //estrategia
			}
		}

		public static void informarGeneral (Coleccionable<Comparable> coleccionable) { //EJERCICIO2
			Console.WriteLine("----------INFORME----------");
			Console.WriteLine("La {0} posee {1} elementos.", coleccionable.ToString(), coleccionable.cuantos());
			Console.WriteLine("Minimo >> " + (coleccionable.minimo()));
			Console.WriteLine("Maximo >> " + (coleccionable.maximo()));	
			Alumno alumno = new Alumno();
			(coleccionable.minimo()).compararPorConsola(coleccionable);
		}
	}
}