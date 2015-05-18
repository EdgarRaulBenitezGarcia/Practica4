
using System;

namespace mysqlConnect
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int menu;
			string nombre;
			string telefono,id;
			Alumnos alumnos = new Alumnos();
			do{
			Console.WriteLine("Conexion con la base de datos\n|1| Agregar\n|2| Mostrar\n|3| Editar (ID)\n|4| Eliminar\n|5| Salir");
				menu=int.Parse(Console.ReadLine());
			switch(menu){
				case 1: 
					Console.WriteLine("ingrese Nombre");
					nombre=Console.ReadLine();
					Console.WriteLine("ingrese telefono");
					telefono=Console.ReadLine();
					Console.WriteLine("ingrese un ID");
					id=Console.ReadLine();
					alumnos.insertarRegistroNuevo(nombre,telefono,id);
					nombre="";
					telefono="";
					id="";
				break;
				
				case 2: alumnos.mostrarTodos();
		
				break;
				
				case 3: 
				Console.WriteLine("campo a modificar\n|1| Nombre\n|2| Telefono\n|3| Salir\n");
				int menu2 = int.Parse(Console.ReadLine());
				switch(menu2){
						case 1 :
							Console.WriteLine("Ingresa un ID,, por favor!!!");
							id=Console.ReadLine();
							Console.WriteLine("Ingresa el nombre");
							nombre=Console.ReadLine();
							alumnos.editarNombreRegistro(id,nombre);
							break;
						case 2 :Console.WriteLine("ingresa un ID, por favor");
							id=Console.ReadLine();
							Console.WriteLine("ingresa un telefono");
							telefono=Console.ReadLine();
							alumnos.editarTelefonoRegistro(id,telefono);
							break;
				}
							break;
				
				case 4:
                            Console.WriteLine("Ingresa un ID para eliminarlo");
					id=Console.ReadLine();
					alumnos.eliminarRegistroPorId(id);
					break;
			}
			}while(menu != 5);
			
		}
	}
}

