using System;

public class Persona	
{
	public Persona()
	{
		//Propiedades
    private string nombre;
    private int edad;
    private char sexo;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public char Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }

    //Constructor
    Persona p = new Persona(string nombre, int edad, char sexo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = sexo;
    }

    //Métodos
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Sexo: " + sexo);
    }
    public void CumplirAnios()
    {
        edad++;
        Console.WriteLine(nombre + " ha cumplido " + edad + " años.");
    }
}
