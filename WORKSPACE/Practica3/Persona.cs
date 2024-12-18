﻿/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 17/4/2021
 * Hora: 14:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica3 {
	
	public class Persona : Comparable {
		
		protected string nombre;
		protected int dni;
		protected EstrategiaDeComparacion estrategia = new PorDni();
		
		public EstrategiaDeComparacion getEstrategia {
			get { return estrategia;}
			set { estrategia = value;}
		}	

		public Persona(string nombre, int dni, EstrategiaDeComparacion estrategia) {
			this.nombre = nombre;
			this.dni = dni;
			this.estrategia = estrategia;
		}
		
		public Persona(string nombre, int dni) {
			this.nombre = nombre;
			this.dni = dni;
		}
		
		public Persona(int dni) {
			this.dni = dni;
		}
		
		public Persona() { }		
		
		public string getNombre {
			get { return nombre;}
			set { nombre = value;}
		}
		
		public int getDni {
			get { return dni;}
			set { dni = value;}
		}		
		
		public virtual bool sosIgual(Comparable objeto) { 
			return estrategia.sosIgual(objeto, this); 
		}

		public virtual bool sosMenor(Comparable objeto) { 
			return estrategia.sosMenor(objeto, this);
		}

		public virtual bool sosMayor(Comparable objeto) { 
			return estrategia.sosMayor(objeto, this);
		}		
		
		public override string ToString() {
			return string.Format(">> Persona Nombre = {0}	DNI = {1}", nombre, dni);
		}
	}
}
