namespace Animals
{  
    public class StartUp
    {
        public static void Main(string[] args)
        {          
            try
            {
                Engine engine = new Engine();
                engine.Run();
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
