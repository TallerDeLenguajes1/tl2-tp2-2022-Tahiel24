//Aclaracion: en los target de nlog.config se cambia el path segun donde se este ejecutando el codigo
using NLog;
NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

List<Alumno> ListadoAtletismo = new List<Alumno>();
List<Alumno> ListadoFutbol = new List<Alumno>();
List<Alumno> ListadoVoley = new List<Alumno>();

int cant = 0;
int dni;
int ID;
int curso;
string nombre;
string apellido;
string path;

try
{
    do
    {
        Console.Write("Ingrese la cantidad de alumnos a agregar: ");
cant = Convert.ToInt32(Console.ReadLine());
    } while (cant < 0) ;

    //Logger.Debug("La cantidad de alumnos fue ingresada");
    //Logger.Info("Primer log realizado con exito");
}
catch (System.Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
    Logger.Error(ex.Message);
}

Console.WriteLine("----------------------------------------------------------");
for (int i = 0; i < cant; i++)
{
    
    //Logger.Info("Hay posible error de formato al momento de ingresar nombre y apellido del usuario");
    Console.Write("Ingrese nombre del usuario: ");
    nombre = Console.ReadLine();
    Console.Write("Ingrese apellido del usuario: ");
    apellido = Console.ReadLine();
    try
    {
        do
        {
            Console.Write("Ingrese su DNI: ");
            dni = Convert.ToInt32(Console.ReadLine());
        } while (dni < 0);

    }
    catch (System.Exception ex)
    {
        Logger.Error(ex.Message);
        break;
    }

    try
    {
        Console.Write("Ingrese ID del usuario: ");
        ID = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Logger.Error(ex.Message);
        break;
    }

    try
    {
        do
        {
            Console.Write("Ingrese el curso al que aplica: (1:Voley,2:Atletisimo,3:Futbol): ");
            curso = Convert.ToInt32(Console.ReadLine());
        } while (curso < 1 && curso > 3);
    }
    catch (Exception ex)
    {
        Logger.Error(ex.Message);
        break;
    }

    try
    {
        Alumno nuevoAlum = new Alumno(ID, nombre, apellido, dni, curso);

        switch (nuevoAlum.Curso1)
        {
            case 1:
                ListadoVoley.Add(nuevoAlum);
                break;
            case 2:
                ListadoAtletismo.Add(nuevoAlum);
                break;
            case 3:
                ListadoFutbol.Add(nuevoAlum);
                break;
        }
    }
    catch (Exception ex)
    {
        Logger.Error(ex.Message);
        break;
    }
    Console.WriteLine("----------------------------------------------------------");
}

MetodosUtiles.subirAlumnos(ListadoFutbol, ListadoVoley, ListadoAtletismo);
Logger.Info("Alumnos guardados correctamente en las listas correspondientes");

int desicion;
do
{
    Console.Write("Desea vaciar algun listado? (0:Si, 1:No): ");
    desicion = Convert.ToInt32(Console.ReadLine());
} while (desicion < 0 && desicion > 1);

if (desicion == 0)
{
    int desicion2;
    Console.WriteLine("Ingrese archivo a vaciar: ");
    Console.WriteLine("1-Voley");
    Console.WriteLine("2-Futbol");
    Console.WriteLine("3-Atletismo");
    do
    {
        Console.Write("Respuesta: ");
        desicion2 = Convert.ToInt32(Console.ReadLine());
    } while (desicion2 < 1 && desicion2 > 3);
    Console.WriteLine("\n");
    switch (desicion2)
    {
        case 1:
            path = @"C:\TALLER 2\tl2-tp2-2022-Tahiel24\Punto3\Voley.csv";
            MetodosUtiles.limpiarArchivo(path);
            Console.WriteLine("Listado borrado con exito");
            Console.WriteLine("Programa finalizado");
            break;
        case 2:
            path = @"C:\TALLER 2\tl2-tp2-2022-Tahiel24\Punto3\Futbol.csv";
            MetodosUtiles.limpiarArchivo(path);
            Console.WriteLine("Listado borrado con exito");
            Console.WriteLine("Programa finalizado");
            break;
        case 3:
            path = @"C:\TALLER 2\tl2-tp2-2022-Tahiel24\Punto3\Atletismo.csv";
            MetodosUtiles.limpiarArchivo(path);
            Console.WriteLine("Listado borrado con exito");
            Console.WriteLine("Programa finalizado");
            break;
    }
}
else
{
    Console.WriteLine("Programa finalizado");
}





