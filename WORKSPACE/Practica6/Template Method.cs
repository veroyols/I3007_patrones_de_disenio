/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 19/6/2021
 * Hora: 17:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica6 {

	abstract public class Template_Method {
		protected List<int> mazo;
		protected int cdadCartas = 50;
		protected int cdadInicial = 7;
		protected int puntos1 = 0;
		protected int puntos2 = 0;
		protected int objetivo;
		protected int ind = 0;
		protected GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
		
		public Persona pasos(Persona j1, Persona j2){
			Persona ganador;
			do {
				Console.WriteLine("Jugar hasta terminar el mazo");
				this.mezclarElMazo();
				this.repartirCartasIniciales(j1, j2);
				while(this.jugarUnaMano()){
					this.tomarCartas(j1);
					this.descartarCartas(j1);
					this.tomarCartas(j2);
					this.descartarCartas(j2);
				}
				ganador = this.chequearGanador(j1, j2);
				ganador.getEstrategia = new PorNombre();
				if (ganador.sosIgual(j1)) {
					puntos1 += 10;
				}
				else {
					puntos2 += 10;					
				}
			Console.WriteLine (" J1     J2 \n-----|----- \n {0}  |   {1}",puntos1,puntos2);
			Console.ReadKey(true);
			} while ((puntos1 < objetivo) && (puntos2 < objetivo));
		
			if (puntos1 > puntos2) {
				return j1;
			}
			return j2;
		}
		protected void mezclarElMazo(){
			Console.WriteLine("mezclarElMazo");
			int carta;
			while (mazo.Count <= cdadCartas) {
				carta = generador.numeroAleatorio(cdadCartas) + 1;
				if (!mazo.Contains(carta)) {
					mazo.Add(carta);
				}
			}
			Console.WriteLine("Mazo Mezclado");
			foreach (int element in mazo) {
				Console.Write(element + " ");
			}
			Console.WriteLine(".");
			
		}
		protected void repartirCartasIniciales(Persona j1, Persona j2){ 
			Persona [] jugadores = new Persona[2] {j1,j2};
			foreach (Persona element in jugadores) {
				Console.Write("Cartas Iniciales -> ");
				element.getCartas = mazo.GetRange(0,cdadInicial-1);
				mazo.RemoveRange(0,cdadInicial-1);
				foreach (int card in element.getCartas) {
					Console.Write(card + " ");
				}	
				Console.WriteLine(".");
			}
		}
		protected bool jugarUnaMano(){ //mientras queden cartas
			ind++;
			if (mazo.Count == 1) { //? ==0
				return false;
			}
			Console.WriteLine("Mano {0}", ind);
			return true;
		}
			
		protected void tomarCartas(Persona j1) { //pop
			Console.Write("Levanta -> {0} ", mazo[0]);
			j1.getCartas.Add(mazo[0]);
			mazo.RemoveAt(0);
			return;			
		}		
		abstract protected void descartarCartas(Persona j1);
		abstract protected Persona chequearGanador(Persona j1, Persona j2);
	}
	
	public class JuegoDeCartas : Template_Method {
		//puedo poner personas de atributo en el constructor y sacarlas de los parametros de ls metodos?
		
		public JuegoDeCartas (int objetivo) { 
			this.mazo = new List<int>();
			this.objetivo = objetivo;
		}
		
		override protected void descartarCartas(Persona j1) { //se descarta la carta de mayor valor numerico
			int max = -1;
			for (int i = 0; i < j1.getCartas.Count; i++) {
				if (j1.getCartas[i] > max) {
					max = j1.getCartas[i]; 
				}	
			}
			Console.Write("| Descarta -> {0} ",max);
			
			j1.getCartas.Remove(max);
			foreach (int element in j1.getCartas) {
				Console.Write(element + " ");
			}
			Console.WriteLine("");
		}
		override protected Persona chequearGanador(Persona j1, Persona j2) {
			int suma1 = 0;
			int suma2 = 0;
			Console.WriteLine("Las cartas suman:");
			foreach (int carta in j1.getCartas) {
				suma1 += carta;
			}
			foreach (int carta in j2.getCartas) {
				suma2 += carta;
			}
			Console.WriteLine("J1 = {0} y J2 = {1}",suma1,suma2);
			Persona ganador;
			if (suma1 > suma2) {
				ganador = j2;
			}
			else {
				ganador = j1;
			}
			return ganador;
		}
	}
}
