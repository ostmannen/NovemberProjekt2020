using System.Collections.Generic;
using System;
using Raylib_cs;

namespace NovemberProjekt
{
    public class Meteorite
    {
        public int height = 100;
        public int width = 100;
        public float xPos;
        public float yPos = -100;
        private float fallSpeed = 5;
        public Random generator = new Random();
        public Rectangle hej;
        public static List<Meteorite> allMeteorites = new List<Meteorite>();
        public Meteorite()
        {
            xPos = random(0, 800);
            hej = new Rectangle(xPos, yPos, width, height);
        }
        public void update(){
            hej.y += fallSpeed;

            Raylib.DrawRectangleRec(this.hej, Color.BLACK);
            if (yPos >= 600)
            {
                allMeteorites.Remove(this);
            }
        }
        static public void spawner(){
            allMeteorites.Add(new Meteorite());
        }
        public int random(int min, int max){
            int k = generator.Next(min, max);
            return k;
        }
    }
}
