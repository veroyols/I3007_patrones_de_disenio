/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 25/5/2021
 * Hora: 19:54
 * 
 */
using System;

namespace Practica4 {
	
	public abstract class FabricaDeComparables {
		
		protected GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
		public const int ALUMNO = 1;
		public const int NUMERO = 2;
		public const int VENDEDOR = 3;
			
		public static Comparable crearAleatorio (int queComparable){
			FabricaDeComparables fabrica = null;		
			switch(queComparable){
				case ALUMNO: 
			        fabrica = new FabricaDeAlumno();
			        break;
			    case NUMERO:
			        fabrica = new FabricaDeNumero();
			        break;
			    case VENDEDOR:
			        fabrica = new FabricaDeVendedor();
			        break;
			}
		return fabrica.crearComparableAleatorio();
		}
		public static Comparable crearPorTeclado (int queComparable){
			FabricaDeComparables fabrica = null;
			switch(queComparable){
				case ALUMNO: 
			        fabrica = new FabricaDeAlumno();
			        break;
			    case NUMERO:
			        fabrica = new FabricaDeNumero();
			        break;
			    case VENDEDOR:
			        fabrica = new FabricaDeVendedor();
			        break;
			}
		return fabrica.crearComparablePorTeclado();
		}
		public abstract Comparable crearComparableAleatorio();		
		public abstract Comparable crearComparablePorTeclado();		
	}
	
	public class FabricaDeAlumno : FabricaDeComparables{
		public override Comparable crearComparableAleatorio(){
			return new Alumno();
		}	
		public override Comparable crearComparablePorTeclado(){
			Console.Write("Ingrese nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese dni: ");
			int dni = int.Parse(Console.ReadLine());
			Console.Write("Ingrese promedio: ");
			int promedio = int.Parse(Console.ReadLine());
			//estrategia por defecto en Alumno
			return new Alumno(nombre,dni,promedio);
		}		
	}
	
	
	
		
	public class FabricaDeNumero: FabricaDeComparables{
		public override Comparable crearComparableAleatorio(){
			return new Numero(generador.numeroAleatorio(1000));
		}
		public override Comparable crearComparablePorTeclado(){
			Console.WriteLine("Ingrese numero entero");
			return new Numero(int.Parse(Console.ReadLine()));
		}
	}
	
	public class FabricaDeVendedor: FabricaDeComparables{ 
		public override Comparable crearComparableAleatorio(){
			string nombre = generador.stringAleatorio(4);
			int dni = generador.numeroAleatorio(99999999);
			int sueldo = generador.numeroAleatorio(1000);
			//estrategia por defecto en Bonus
			return new Vendedor(nombre,dni,sueldo);		}
		public override Comparable crearComparablePorTeclado(){
			Console.Write("Ingrese nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese dni: ");
			int dni = int.Parse(Console.ReadLine());
			Console.Write("Ingrese sueldo $");
			int sueldo = int.Parse(Console.ReadLine());
			//estrategia por defecto en Bonus
			return new Vendedor(nombre,dni,sueldo);
		}
	}//E9	
}
	
	

