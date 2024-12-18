﻿/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 15/4/2021
 * Hora: 22:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica1
{
	public class Cola : Coleccionable<Comparable> { //FIFO
		
		private List<Comparable> elementos;
	
		public List<Comparable> Elementos { //declara propiedad pública
			set { elementos = value; } //se ejecuta al escribir
			get { return elementos; } //se ejecuta al leer 
		}
	
		public Cola () {
			elementos = new List<Comparable>();  
		}
		
		public int cuantos() { //cantidad de elementos
			return elementos.Count;
		}

		public bool Empty () {
			bool vacia = false;
			if (cuantos() == 0) {
				vacia = true;
			}
			return vacia;
		}
				
		public Comparable minimo() { //elemento de menor valor de la colección
			if (Empty()) {
				return null;
			}
			Comparable min = elementos[0];
			for (int i = 0; i < cuantos(); i++) {
				if ((elementos[i]).sosMenor(min) ) {
					min = elementos[i];
				}
			}
			return min; 
		}
		
		public Comparable maximo() { //elemento de mayor valor de la colección
			if (Empty()) { //validacion
				return null;
			}
			Comparable max = elementos[0];
			for (int i = 0; i < cuantos(); i++) {
				if ((elementos[i]).sosMayor(max) ) {
					max = elementos[i];
				}
			}
			return max; 
		}		
	
		public void agregar(Comparable objeto) {
			elementos.Add(objeto);	
		}

		public bool contiene(Comparable objeto) { //verdadero si el parámetro pertenece
			bool cont = false;
			foreach (Comparable element in elementos) {
				if (element.sosIgual(objeto))
					cont = true;
				}
			return cont; 
		}

		public override string ToString() {
			return string.Format("Cola");
		}		
	}
}
