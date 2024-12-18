﻿/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 20/6/2021
 * Hora: 15:33
 * 
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace Practica7 {
	
	public class ObtenerDatos {
		private Manejador manejador = crearCadenaDeResponsabilidades();
		public Manejador getManejador {
			get { return manejador; }
			set { manejador = value; }
		}
		public ObtenerDatos(){ }
		
		private static Manejador crearCadenaDeResponsabilidades(){
			Manejador m = new LectorDeDatos(null);
			m = new GeneradorDeDatosAleatorio(m);
			m = new LectorDeArchivos(m);
			return m;
		}		
	}
	
	public abstract class Manejador {
		protected Manejador sucesor = null;
		
		public Manejador(Manejador sucesor) {
			this.sucesor = sucesor;
		}
		
		virtual public int numeroPorTeclado () {
			int num = -1;
			if (sucesor != null) {
				num = sucesor.numeroPorTeclado();
			}
			return num;
		}
		virtual public string stringPorTeclado () {
			string st = "";
			if (sucesor != null) {
				st = sucesor.stringPorTeclado();
			}
			return st;
		}
		virtual public int numeroAleatorio (int max) {
			int num = -1;
			if (sucesor != null) {
				num = sucesor.numeroAleatorio(max);
			}
			return num;
		}
		virtual public string stringAleatorio (int cant) {
			string st = "";
			if (sucesor != null) {
				st = sucesor.stringAleatorio(cant);
			}
			return st;
		}
		
		virtual public int numeroDesdeArchivo(int max){
			int num = -1;
			if (sucesor != null) {
				num = sucesor.numeroDesdeArchivo(max);
			}
			return num;
		}
		
		virtual public string stringDesdeArchivo(int cant){
			if (sucesor != null) {
				return sucesor.stringDesdeArchivo(cant);
			}
			return null;
		}		
	}
	
	public class LectorDeDatos : Manejador {
		
		public LectorDeDatos(Manejador manejador) : base(manejador) {}
		
		public override int numeroPorTeclado () {
			return int.Parse(Console.ReadLine());
		}
		
		public override string stringPorTeclado () {
			return Console.ReadLine();
		}	
	}

	public class GeneradorDeDatosAleatorio : Manejador {
		
		public GeneradorDeDatosAleatorio(Manejador manejador) : base (manejador) {}
		private static Random random = new Random();

		public override int numeroAleatorio (int max) {
			return (random.Next(99999999)) % (max+1);
		} 
		
		public override string stringAleatorio (int cant) {
			string letras = "abcdefghijklmnopqrstuvwxyz";//26
			string palabra = null;
			for (int i = 0; i < cant; i++) {
				palabra += letras[numeroAleatorio(25)];
			}
			return palabra;
		} 
	}

	public class LectorDeArchivos : Manejador {
		
//		private const string ruta_archivo = @"C:\Users\veros\Documents\GitHub\I3007\WORKSPACE\Practica7\bin\Debug\datos.txt";
		private const string ruta_archivo = @"C:\Users\veros\Documents\GitHub\I3007\WORKSPACE\Practica7\bin\Debug\nuevo.txt";
		
		private StreamReader lector_de_archivos;
		
		public LectorDeArchivos(Manejador manejador) : base(manejador) {
//			lector_de_archivos = new StreamReader(ruta_archivo,true);
		}
		
		public override int numeroDesdeArchivo(int max){
			string linea = lector_de_archivos.ReadLine();
			return int.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
		}
		
		public override string stringDesdeArchivo(int indice){
			lector_de_archivos = new StreamReader(ruta_archivo,false);
			List<string> alumnos = new List<string>();
			string linea; 
			while (lector_de_archivos.Peek() > -1){ //-1 si no hay caracteres para leer
				linea = lector_de_archivos.ReadLine();
				alumnos.Add(linea);
			}
			lector_de_archivos.Close();
			if (indice == alumnos.Count) {
				return null;
			}
			else {
				return alumnos[indice];
			}
//			linea = linea.Substring(linea.IndexOf('\t')+1);
//			cant = Math.Min(cant, linea.Length);
//			return linea.Substring(0, cant);
		}
	}
}
