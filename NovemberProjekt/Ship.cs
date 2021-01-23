using System;
using Raylib_cs;

namespace NovemberProjekt
{
    public class Ship
    {
        private int hp = 3;
        private float movementSpeed = 5;
        private float fireSpeed = 1;
        public Rectangle shipRec = new Rectangle(375, 400, 50, 50);
        
        public void update(){
            Raylib.DrawRectangleRec(shipRec, Color.PINK);
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && shipRec.x <= 750){
                shipRec.x += movementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && shipRec.x != 0){
                shipRec.x -= movementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && shipRec.y >= 0){
                shipRec.y -= movementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && shipRec.y <= 550){
                shipRec.y += movementSpeed;
            }
            for (int i = 0; i < Meteorite.allMeteorites.Count; i++)
            {
                if (Raylib.CheckCollisionRecs(shipRec, Meteorite.allMeteorites[i].hej))
                {
                    Meteorite.allMeteorites.RemoveAt(i);
                    hp--;
                    if (hp <= 0){
                        System.Console.WriteLine("hej");
                    }
                }
            }
        }
    }
}
