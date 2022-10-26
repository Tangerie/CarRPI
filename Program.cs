using Raylib_cs;


namespace HelloWorld {
    static class Program {
        public static void Main() {
            Raylib.InitWindow(1024, 600, "Hello World");

            while(!Raylib.WindowShouldClose()) {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawText("RAYLIB", 10, 10, 20, Color.GREEN);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}