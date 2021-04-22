/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 21/4/2021
 * Hora: 21:52
 * 
 */
using System;

namespace Practica1
{
	public interface estrategiaDeComparacion{
		bool comparar();
	}
	
	public class PorNombre : estrategiaDeComparacion {
		public bool comparar() {
			return true;
		}
	}

	public class PorDni : estrategiaDeComparacion {
		public bool comparar() {
			return true;
		}
	}

	public class PorLegajo : estrategiaDeComparacion {
		public bool comparar() {
			return true;
		}
	}

	public class PorPromedio : estrategiaDeComparacion {
		public bool comparar() {
			return true;
		}
	}	
}
