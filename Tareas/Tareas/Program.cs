// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n===Programa para Tareas===\n");
int cantidad = 0;
int duracion = 0;
string descripcion;

do
{
    Console.WriteLine("Ingrese la cantidad de tareas que debe realizar:");
    cantidad = int.Parse(Console.ReadLine());
} while (cantidad <= 0);

List<Tarea> tareasPendientes = new List<Tarea>();

for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine("\n=========Ingreso de datos de la tarea " + (i + 1)+ "=========\n");
    Console.WriteLine("Ingrese la descripcion de la tarea "+(i+1));
    descripcion = Console.ReadLine();

    do
    {
        Console.WriteLine("Ingrese la duracion de la tarea "+(i+1));
        duracion = int.Parse(Console.ReadLine());
    }while (duracion < 10 && duracion > 100);

    tareasPendientes.Add(new Tarea(duracion, descripcion, Estado.Incompleta));
}

//Muestro las tareas pendientes
for(int j = 0; j < tareasPendientes.Count; j++)
{
    Console.WriteLine(tareasPendientes[j].ToString());
}

List<Tarea> tareasRealizadas = new List<Tarea>();
int opcion = 0;
//int longitud = tareasPendientes.Count;

Console.WriteLine("\n===Control de tareas realizadas===\n");
for(int k=0; k < tareasPendientes.Count; k++)
{
    do
    {
        Console.WriteLine(tareasPendientes[k].ToString());
        Console.WriteLine("La tarea ya esta realizada? Si:0 / No:1\n");
        opcion = int.Parse(Console.ReadLine());
    }while(opcion != 0 && opcion != 1);

    if(opcion == 0)
    {
        tareasRealizadas.Add(tareasPendientes[k]);
        //tareasPendientes.Remove(tareasPendientes[k]);
        EliminaTarea(tareasPendientes[k]);
    }
}

Console.WriteLine("\n====Tareas realizadas====\n");
for(int l = 0; l < tareasRealizadas.Count; l++)
{
    Console.WriteLine(tareasRealizadas[l].ToStringComp());
}

Console.WriteLine("\n====Tareas pendientes====\n");
for (int s = 0; s < tareasPendientes.Count; s++)
{
    Console.WriteLine(tareasPendientes[s].ToStringInc());
}

void EliminaTarea(Tarea tareaElimina)
{
    tareasPendientes.Remove(tareaElimina);
}