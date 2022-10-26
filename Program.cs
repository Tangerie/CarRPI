using Raylib_cs;


namespace HelloWorld {
    static class Program {
        public static void Main() {
            Console.WriteLine("Hello, World!");
            Raylib.InitWindow(800, 400, "Hello World");

            while(!Raylib.WindowShouldClose()) {
                
            }

            Raylib.CloseWindow();
        }
    }
}