namespace Examen_RentaCar_Thomas
{
    internal static class Program
    {

    
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
