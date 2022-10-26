using Raylib_cs;


namespace HelloWorld {
    static class Program {
        public static void Main() {
            Raylib.InitWindow(1024, 600, "Hello World");

            double y = 0.0;
            double dir = 1.0;
            
            double delta = 1.0;

            while(!Raylib.WindowShouldClose()) {
                delta = 1000.0 / Raylib.GetFPS();
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawText("RAYLIB", 500, (int) Math.Round(y), 20, Color.GREEN);

                if(y >= 600) {
                    dir = -1;
                } else if (y <= 0) {
                    dir = 1;
                }

                if(Raylib.GetFPS() > 10) {
                    y += dir * delta;
                }

                Raylib.DrawText("FPS: " + y.ToString(), 10, 10, 20, Color.RED);
                Raylib.DrawText("D: " + delta.ToString(), 10, 40, 20, Color.RED);
                Raylib.DrawText("X: " + Raylib.GetTouchX().ToString(), 10, 70, 20, Color.RED);
                Raylib.DrawText("Y: " + Raylib.GetTouchY().ToString(), 10, 100, 20, Color.RED);


                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}