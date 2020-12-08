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
                player.drawShip();
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
                    System.Console.WriteLine(player.yPos);
                    System.Console.WriteLine(player.xPos);
                    Projectile.createProjektile(new Projectile() {ProjectileXPos = player.xPos + 20, ProjectileYPos = player.yPos});
                }
                if (meteoriteTimer >= meteoriteDelay)
                {
                    Meteorite.spawner();
                    meteoriteTimer = 0;
                }
                for (int i = 0; i < Meteorite.allMeteorites.Count; i++)
                {
                    for (int i = 0; i < length; i++)
                    {
                        
                    }
                }
                if (Projectile.allProjectiles[1].ProjectileXPos <= Meteorite.allMeteorites[1].xPos){
                    System.Console.WriteLine("bith");
                }
                //lambda expression
                Raylib.EndDrawing();
            }
            Console.ReadLine();
        }
    }
}
