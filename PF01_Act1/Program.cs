namespace PF01_Act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Juan", 25, 'M');

            p.MostrarInformacion();
            p.CumplirAnios();
        }
    }
}