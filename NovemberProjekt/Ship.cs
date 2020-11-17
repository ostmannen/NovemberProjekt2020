using System;
using Raylib_cs;

namespace NovemberProjekt
{
    public class Ship
    {
        private int hp = 3;
        private float movementSpeed = 1;
        private float fireSpeed = 1;
        private float xPos = 0;
        private float yPos = 0;
        private int height = 50;
        private int width = 50;
        
        public void drawShip(){
            Raylib.DrawRectangle((int)xPos,(int)yPos,width,height, Color.PINK);
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)){
                xPos += movementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)){
                xPos -= movementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)){
                yPos -= movementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)){
                yPos += movementSpeed;
            }
        }
    }
}
