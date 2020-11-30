using System;
using Raylib_cs;

namespace NovemberProjekt
{
    public class Ship
    {
        private int hp = 3;
        private float movementSpeed = 5;
        private float fireSpeed = 1;
        public float xPos = 375;
        public float yPos = 400;
        private int height = 50;
        private int width = 50;
        
        
        public void drawShip(){
            Raylib.DrawRectangle((int)xPos,(int)yPos,width,height, Color.PINK);
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && xPos <= 750){
                xPos += movementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && xPos != 0){
                xPos -= movementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && yPos >= 0){
                yPos -= movementSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && yPos <= 550){
                yPos += movementSpeed;
            }
        }
    }
}
