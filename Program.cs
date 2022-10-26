using Raylib_cs;


namespace HelloWorld {
    static class Program {
        public static void Main() {
            Console.WriteLine("Hello, World!");
            Raylib.InitWindow(800, 400, "Hello World");

            while(!Raylib.WindowShouldClose()) {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);

                Raylib.DrawText("Hello C# Window", 10, 10, 20, Color.RED);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}