/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 25/5/2021
 * Hora: 19:20
 * 
 */
using System;

namespace Practica3 {
	
	public class GeneradorDeDatosAleatorio {
		
		private static Random random = new Random();

		/*numeroAleatorio(max)  Devuelve un número aleatorio entre 0 y max*/
		public int numeroAleatorio (int max) {
			return (random.Next(99999999)) % (max+1);
		} //E2
		
		/*stringAleatorio(cant)  Devuelve un string aleatorio de cant caracteres*/
		public string stringAleatorio (int cant) {
			string letras = "abcdefghijklmnopqrstuvwxyz";//26
			string palabra = null;
			for (int i = 0; i < cant; i++) {
				palabra += letras[numeroAleatorio(25)];
			}
			return palabra;
		} //E2
		
		public GeneradorDeDatosAleatorio() {}
	}
}
