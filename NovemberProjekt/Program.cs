using System.Net.NetworkInformation;
using System;
using Raylib_cs;

namespace NovemberProjekt
{
    class Program
    {
        private static System.Timers.Timer aTimer;
        
        
        static void Main(string[] args)
        {
            float bulletTimer = 60;
            float bulletDelay = 60;
            
            Raylib.InitWindow(800, 600, "Game Engine");
            Raylib.SetTargetFPS(60);
            Ship player = new Ship();
            //Projectile.allProjectiles 
            System.Console.WriteLine("hej");
            


            while (!Raylib.WindowShouldClose()){
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GRAY);
                player.drawShip();
                bulletTimer += 1;
                for (int i = 0; i < Projectile.allProjectiles.Count; i++)
                {
                    Projectile.allProjectiles[i].update();
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) && bulletTimer >= bulletDelay)
                {
                    bulletTimer = 0;
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
