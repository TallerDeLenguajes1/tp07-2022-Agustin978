using System;

public class Tarea
{
	private static int ID;
    public int IDNext { get; private set; }
	int duracion;
	string descripcion;
	Estado estadoT;

	public Tarea(int duracion, string descripcion, Estado estadoT)
    {
        this.duracion = duracion;
        this.descripcion = descripcion;
        this.estadoT = estadoT;
        Contador();
        //this.ID = Contador();
    }

    private int Contador()
    {
		return Interlocked.Increment(ref ID);
    }

    private int ContadorRecupera()
    {
        return ID;
    }

    public override string ToString() => "---->ID tarea: " + ContadorRecupera() + "\n->Descripcion: " + this.descripcion + "\n->Duracion: " + this.duracion + "\n";
    public string ToStringInc() => "---->ID tarea: " + ContadorRecupera() + "\n->Descripcion: " + this.descripcion + "\n->Duracion: " + this.duracion + "\n->Tarea incompleta =(\n";

    public string ToStringComp() => "---->ID tarea: " + ContadorRecupera() + "\n->Descripcion: " + this.descripcion + "\n->Duracion: " + this.duracion + "\n->Tarea completa =)\n";

}
