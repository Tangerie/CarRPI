using Raylib_cs;


namespace HelloWorld
{
    static class Program
    {
        public static unsafe void Main()
        {
            Raylib.InitWindow(1024, 600, "Hello World");


            double delta = 1.0;
            Color c = new Color();
            c.a = 0xff;
            Image im = Raylib.GenImageColor(1024, 600, Color.RED);

            
            bool exit = false;

            for (int x = 0; x < 1024; x++)
            {
                c.r = Convert.ToByte((int)(x / 1024.0 * 0xff));
                for (int y = 0; y < 600; y++)
                {
                    c.g = Convert.ToByte((int)((1.0 - y / 600.0) * 0xff));
                    Raylib.ImageDrawPixel(& im, x, y, c);
                }
            }

            Texture2D tex = Raylib.LoadTextureFromImage(im);

            Raylib.UnloadImage(im);

            while (!Raylib.WindowShouldClose() && !exit)
            {
                delta = 1000.0 / Raylib.GetFPS();
                Raylib.BeginDrawing();
                // Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawTexture(tex, 0, 0, Color.WHITE);


                Raylib.DrawText("FPS: " + Raylib.GetFPS().ToString(), 10, 10, 20, Color.RED);
                Raylib.DrawText("D: " + delta.ToString(), 10, 40, 20, Color.RED);
                Raylib.DrawText("X: " + Raylib.GetTouchX().ToString(), 10, 70, 20, Color.RED);
                Raylib.DrawText("Y: " + Raylib.GetTouchY().ToString(), 10, 100, 20, Color.RED);

                if(Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) {
                    Raylib.DrawCircle(Raylib.GetTouchX(), Raylib.GetTouchY(), 30, Color.BLUE);

                    if(Raylib.GetTouchX() < 20 &&  Raylib.GetTouchY() < 20) {
                        exit = true;
                    }
                }


                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}