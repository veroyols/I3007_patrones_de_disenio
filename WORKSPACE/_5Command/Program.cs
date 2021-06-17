/*
 * Creado por SharpDevelop.
 * Usuario: veros
 * Fecha: 15/6/2021
 * Hora: 22:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace _5Command
{
	public class Program
	{
		static IOrden ordenPush = new NoHacerNada();
		static IOrden ordenPop = new NoHacerNada();
		static Enfermero enfermero = new Enfermero(ordenPush, ordenPop);
			
		public static void Main(string[] args)	{			
			char opcion;
			mostrarMenu();
			opcion = ' ';
			while(opcion != 's'){
				mostrarMenu();	
				switch(opcion){
						case 'i': ingresarPaciente(new Paciente()); break;
						case 'a': atenderPaciente(); break;
						case 'u': cambiarOrdenPush(); break;
						case 'o': cambiarOrdenPop(); break;
				}
				opcion = Console.ReadKey().KeyChar;
			}
			
			Console.Write("\n\n\nPrograma finalizado correctamente.");
			Console.ReadKey(true);
		}
		
		static private void ingresarPaciente(Paciente p){			
			enfermero.recibirPaciente(p);
		}
		
		static private void atenderPaciente(){
			if(enfermero.hayPacientesEnEspera())
				enfermero.proximoAAtender();
			else
				Console.WriteLine("Enfermero: No hay pacientes en espera");
		}
		
		static private void cambiarOrdenPush(){
			Console.WriteLine("¿Qué orden?");
			Console.WriteLine("(n)inguna");
			Console.WriteLine("(t)omar la presión");
			Console.WriteLine("(o)frecer taza de cafe");
			Console.WriteLine("(a)mbas");
			
			bool ok = true;
			IOrden orden = null;
			while(ok){
				char opcion = Console.ReadKey().KeyChar;
				orden = FabricaDeOrdenes.crearOrden(opcion);
				ok = orden == null;
			}
			enfermero.setOrdenPush(orden);
			Console.WriteLine("Orden cambiada");
		}
		
		static private void cambiarOrdenPop(){
			Console.WriteLine("¿Qué orden?");
			Console.WriteLine("(n)inguna");
			Console.WriteLine("(p)almear la espalda");
			Console.WriteLine("(d)esinfectar asiento");
			Console.WriteLine("a(m)bas");
			
			bool ok = true;
			IOrden orden = null;
			while(ok){
				char opcion = Console.ReadKey().KeyChar;
				orden = FabricaDeOrdenes.crearOrden(opcion);
				ok = orden == null;
			}
			enfermero.setOrdenPop(orden);
			Console.WriteLine("Orden cambiada");
		}
		
		static private void mostrarMenu(){
			Console.Clear();
			Console.WriteLine("Seleccione una opción");
			Console.WriteLine("(i)ngresar un paciente al hospital");
			Console.WriteLine("(a)tender paciente");
			Console.WriteLine("cambiar orden \"p(u)sh\"");
			Console.WriteLine("cambiar orden \"p(o)p\"");
			Console.WriteLine("(s)alir");
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("");
		}
	}
}