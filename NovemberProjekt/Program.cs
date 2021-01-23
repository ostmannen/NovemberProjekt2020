using System.Net.NetworkInformation;
using System;
using Raylib_cs;

namespace NovemberProjekt
{
    class Program
    {        
        static void Main(string[] args)
        {
            float bulletTimer = 60;

            float bulletDelay = 60;

            float meteoriteTimer = 60;

            float meteoriteDelay = 60; 

            Raylib.InitWindow(800, 600, "Game Engine");

            Raylib.SetTargetFPS(60);

            Ship player = new Ship();
            
            while (!Raylib.WindowShouldClose()){
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GRAY);
                player.update();
                bulletTimer += 1;
                meteoriteTimer += 1;
                for (int i = 0; i < Projectile.allProjectiles.Count; i++)
                {
                    Projectile.allProjectiles[i].update();
                }
                for (int i = 0; i < Meteorite.allMeteorites.Count; i++)
                {
                    Meteorite.allMeteorites[i].update();
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) && bulletTimer >= bulletDelay)
                {
                    bulletTimer = 0;
                    Projectile.createProjektile(new Projectile() {ProjectileXPos = player.shipRec.x + 20, ProjectileYPos = player.shipRec.y});
                    //  ¯\_(ツ)_/¯
                }
                if (meteoriteTimer >= meteoriteDelay)
                {
                    Meteorite.spawner();
                    meteoriteTimer = 0;
                }
                //lambda expression
                Raylib.EndDrawing();
            }
            Console.ReadLine();
        }
    }
}
