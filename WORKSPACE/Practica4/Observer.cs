/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 26/5/2021
 * Hora: 19:58
 * 
 */
using System;

namespace Practica4 {
	
	public interface Observador { 
		void actualizar(Observado observado, int monto); //ventas 
	} //gerente

	public interface Observado { 
		void agregarObservador(Observador observador);
		void notificar(int monto); //jornada de ventas
		//list
	} //vendedor	
}