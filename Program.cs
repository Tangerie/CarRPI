using Raylib_cs;


namespace HelloWorld {
    static class Program {
        public static void Main() {
            Raylib.InitWindow(1024, 600, "Hello World");

            float y = 0;
            int dir = 1;
            while(!Raylib.WindowShouldClose()) {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawText("RAYLIB", 500, (int) Math.Floor(y), 20, Color.GREEN);

                if(y >= 600) {
                    dir = -1;
                } else if (y <= 0) {
                    dir = 1;
                }

                y += dir * 0.1f;

                Raylib.DrawText("X: " + Raylib.GetTouchX().ToString(), 10, 10, 20, Color.RED);
                Raylib.DrawText("Y: " + Raylib.GetTouchY().ToString(), 10, 40, 20, Color.RED);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}