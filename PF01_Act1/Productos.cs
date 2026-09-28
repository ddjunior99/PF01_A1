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
<<<<<<< HEAD
		Nombre = nombre;
		recio = precio;
=======
		this.nombre = nombre;
		this.precio = precio;
>>>>>>> func2
		this.calidad = calidad;
	}

	//Métodos
<<<<<<< HEAD
	public void MostrarDatos()
=======
	public void MostrarDatosProductos()
>>>>>>> func2
	{
		Console.WriteLine("Nombre: " + nombre);
		Console.WriteLine("Precio: " + precio);
		Console.WriteLine("Calidad: " + calidad);
	}
<<<<<<< HEAD
=======

	
>>>>>>> func2
}
