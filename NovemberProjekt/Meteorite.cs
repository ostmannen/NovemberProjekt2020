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
        public Rectangle meteoriteRec;
        public static List<Meteorite> allMeteorites = new List<Meteorite>();
        //En lista med alla mereorites
        public Meteorite()
        {
            xPos = random(0, 800);
            //x värdet kommer slumpas mellan 0 och 800
            meteoriteRec = new Rectangle(xPos, yPos, width, height);
            //skapar en rektangel 
        }
        public void update(){
            meteoriteRec.y += fallSpeed;
            //gör så att metioriterna faller varje frame

            Raylib.DrawRectangleRec(this.meteoriteRec, Color.BLACK);
            if (yPos >= 600)
            {
                allMeteorites.Remove(this);
                //tar bort metioriten ifall y värdet är för högt
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
