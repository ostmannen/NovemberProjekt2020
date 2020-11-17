using System.Net.NetworkInformation;
using System;
using Raylib_cs;

namespace NovemberProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Game Engine");
            Raylib.SetTargetFPS(60);
            Ship player = new Ship();

            while (!Raylib.WindowShouldClose()){
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GRAY);
                player.drawShip();
                Raylib.EndDrawing();
            }

            Console.ReadLine();

            
        }
    }
}
