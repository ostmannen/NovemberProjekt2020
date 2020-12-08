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
        public Random generator = new Random();
        public static List<Meteorite> allMeteorites = new List<Meteorite>();

        public Meteorite()
        {
            xPos = random(0, 800);
        }
        public void update(){
            yPos += 10;
            Raylib.DrawRectangle((int)xPos, (int)yPos, width, height, Color.RED);
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
