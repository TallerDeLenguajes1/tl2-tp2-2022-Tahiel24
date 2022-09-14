class MetodosUtiles{
    public static void subirAlumnos(List<Alumno>futbol, List<Alumno>voley, List<Alumno>atletismo){
        List<string>cadenaf=new List<string>();
        List<string>cadenav=new List<string>();
        List<string>cadenaA=new List<string>();
        //Cambiar el path segun se necesite
        string path=@"C:\TALLER 2\tl2-tp2-2022-Tahiel24\Punto3";
        foreach(var f in futbol){
            cadenaf.Add("Nombre y apellido: "+f.Nombre1+" "+f.Apellido1);
        }
        foreach(var v in voley){
            cadenav.Add("Nombre y apellido: "+v.Nombre1+" "+v.Apellido1);
        }
        foreach(var a in atletismo){
            cadenaA.Add("Nombre y apellido: "+a.Nombre1+" "+a.Apellido1);
        }
        File.AppendAllLines(path+@"\Atletismo.csv", cadenaA);
        File.AppendAllLines(path+@"\Voley.csv", cadenav);
        File.AppendAllLines(path+@"\Futbol.csv", cadenaf);
    }

    public static void limpiarArchivo(string path){
        List<string>limpiar=new List<string>();
        string path1=@"C:\TALLER 2\tl2-tp2-2022-Tahiel24\Punto3";
        limpiar.Add(" ");
        File.WriteAllLines(path,limpiar);
    }
}