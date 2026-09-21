using System;

public class Productos
{
	public Productos()
	{

		//propiedades
		public string nombre;
	public double precio;
	public string calidad;

	public string Nombre
	{
		get { return nombre; }
		set { nombre = value; }
	}

	public double Precio
	{
		get { return precio; }
		set { precio = value; }

	}
	public string Calidad
	{
		get { return calidad; }
		set { calidad = value; }
	}

	//Constructor

	Producto(string nombre, double precio, string calidad)
	{
		Nombre = nombre;
		recio = precio;
		this.calidad = calidad;
	}
}
