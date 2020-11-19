using System.Net.NetworkInformation;
using System;
using Raylib_cs;
using System.Timers;

namespace NovemberProjekt
{
    class Program
    {
        private static System.Timers.Timer aTimer;
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Game Engine");
            Raylib.SetTargetFPS(60);
            Ship player = new Ship();
            //Projectile.allProjectiles 
            System.Console.WriteLine("hej");

            while (!Raylib.WindowShouldClose()){
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GRAY);
                player.drawShip();
                
                for (int i = 0; i < Projectile.allProjectiles.Count; i++)
                {
                    Projectile.allProjectiles[i].update();
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
                {
                    System.Console.WriteLine(player.yPos);
                    System.Console.WriteLine(player.xPos);
                    Projectile.createProjektile(new Projectile() {ProjectileXPos = player.xPos + 20, ProjectileYPos = player.yPos});
                }
                
              
                //lambda expression

                Raylib.EndDrawing();

            }

            Console.ReadLine();

            
        }
    }
}
