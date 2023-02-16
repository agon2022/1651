internal class Program
{
    static void Main(string[] args)
    {
        KeyboardWindow window1 = KeyboardWindow.Instance;
        window1.Width = 5;
        window1.Height = 10;
        Console.WriteLine(window1);
        KeyboardWindow window2 = KeyboardWindow.Instance;
        window2.Width = 20;
        window2.Height = 30;
        Console.WriteLine(window2);
        Console.WriteLine(window1);
        Console.WriteLine(window1.Equals(window2));
        Console.ReadLine();


    }

    internal class KeyboardWindow
    {
        private static KeyboardWindow instance;
        public static KeyboardWindow Instance
        { 
            get
            { if (instance == null)
                    instance = new KeyboardWindow();
                return instance;
            } 
        }
        public double Height { get; set; }
        public double Width { get; set; }

        public override string ToString()
        {
            return $"Keyboard Window has height {Height} and width {Width}";
        }
    }
}
