/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 21/4/2021
 * Hora: 21:52
 * 
 */
using System;

namespace Practica1 {									/*Ejercicio1
																	Implemente cuatro estrategias de comparación para la clase Alumno
																	(por nombre, por DNI, por promedio y por legajo).*/
	public interface estrategiaDeComparacion{
		bool comparar(Comparable comparable);
	}
	
	public class PorNombre : estrategiaDeComparacion {
		public bool comparar(Comparable comparable) {
//			bool x = false;
//			(((Alumno)comparable).getNombre)
			return true;
		}
	}

	public class PorDni : estrategiaDeComparacion {
		public bool comparar(Comparable comparable) {
			return true;
		}
	}

	public class PorLegajo : estrategiaDeComparacion {
		public bool comparar(Comparable comparable) {
			return true;
		}
	}

	public class PorPromedio : estrategiaDeComparacion {
		public bool comparar(Comparable comparable) {
			return true;
		}
	}	
}
