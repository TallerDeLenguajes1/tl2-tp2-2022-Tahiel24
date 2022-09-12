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

try
{
    do
    {
        Console.Write("Ingrese la cantidad de alumnos a agregar: ");
        cant = Convert.ToInt32(Console.ReadLine());
    } while (cant < 0);

    //Logger.Debug("La cantidad de alumnos fue ingresada");
    //Logger.Info("Primer log realizado con exito");
}
catch (System.Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
    Logger.Error(ex.Message);
}

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
            Console.Write("Ingrese el curso al que aplica: (1:Voley,2:Atletisimo,3:Futbol)");
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
}








