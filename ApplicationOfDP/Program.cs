namespace ApplicationOfDP
{
     public static class Program
    {
        public static Form1 _form1 = null;
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            _form1 = new Form1();
            Application.Run(_form1);
        }
    }
}