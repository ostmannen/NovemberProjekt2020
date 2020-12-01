using System.Collections.Generic;
using System;

namespace NovemberProjekt
{
    public class Meteorite
    {
        private int height = 100;
        private int width = 100;
        private float xPos;
        private float yPos;
        public static List<Meteorite> allMeteorites = new List<Meteorite>();

        public void update(){
            yPos += 10;
        }
        static public void spawner(){
            allMeteorites.Add(new Meteorite());
        }
    }
}
