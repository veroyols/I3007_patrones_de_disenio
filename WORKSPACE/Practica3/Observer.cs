/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 26/5/2021
 * Hora: 19:58
 * 
 */
using System;

namespace Practica3 {
	
	public interface Observador {
		void quitarObservado(Observado observado);
		void agregarObservado(Observado observado);
		void notificar(); //jornada de ventas
	} //gerente

	public interface Observado {
		void actualizar(Observado observado); //ventas 
	} //vendedor	
}