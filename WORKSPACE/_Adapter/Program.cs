/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 29/5/2021
 * Hora: 13:00
 * 
 */
using System;
using System.Collections.Generic;

namespace _Adapter {
	
	public class Program {
				
		public static void Main(string[] args)	{
			Visualizador v = new Visualizador(crearDocumentos());
			
			v.ShowDialog();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
		
		private static List<IDocumento> crearDocumentos(){
			
			List<IDocumento> lista = new List<IDocumento>();
						
			lista.Add(new DocumentoProxy("Contrato de alquiler", 1));
			lista.Add(new DocumentoProxy("Gastos mensuales", 2));
			lista.Add(new DocumentoProxy("Clase 8 de teoría", 3));
			lista.Add(new DocumentoProxy("Ejemplos de la práctica", 3));
			lista.Add(new DocumentoProxy("Mi colección de música", 4));
			lista.Add(new DocumentoProxy("Críticas de películas", 1));
			lista.Add(new DocumentoProxy("Manual del carpintero", 1));
			lista.Add(new DocumentoProxy("Pedido de divorcio", 1));
			lista.Add(new DocumentoProxy("Costo fiesta casamiento", 2));
			lista.Add(new DocumentoProxy("Clase 9 de teoría", 3));
			lista.Add(new DocumentoProxy("Más ejemplos de la práctica", 1));
			lista.Add(new DocumentoProxy("Música para relajarse", 4));
			lista.Add(new DocumentoProxy("Críticas de series", 1));
			lista.Add(new DocumentoProxy("Libro de ficción", 1));
			
			//El objeto adaptado
			lista.Add(new DocumentoProxy("Foto del grupo", 5));
				
			return lista;
		}
		
	}}