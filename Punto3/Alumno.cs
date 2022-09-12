class Alumno
{
    private int ID;
    private string Nombre;
    private string Apellido;
    private int DNI;
    private int Curso;

    public int DNI1 { get => DNI; set => DNI = value; }
    public int Curso1 { get => Curso; set => Curso = value; }
    public string Apellido1 { get => Apellido; set => Apellido = value; }
    public int ID1 { get => ID; set => ID = value; }
    public string Nombre1 { get => Nombre; set => Nombre = value; }

    public Alumno(int id, string nom, string ape, int dni, int cur){
        DNI1=dni;
        Curso1=cur;
        Apellido1=ape;
        ID1=id;
        Nombre1=nom;
    }
}