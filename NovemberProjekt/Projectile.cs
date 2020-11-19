using System;
using Raylib_cs;
using System.Collections.Generic;

namespace NovemberProjekt
{
    public class Projectile
    {


        public bool exists = false;
        public string name = "hej";
        private int projectileCount;
        private int height = 10;
        private int width = 10;
        public float ProjectileYPos;
        public float ProjectileXPos;
        public static List<Projectile> allProjectiles = new List<Projectile>();
        public static void createProjektile(Projectile p){
            allProjectiles.Add(p);
        }
        private void fireProjectile(){
            exists = true;
        }
        public void update(){
            Raylib.DrawRectangle((int)ProjectileXPos, (int)ProjectileYPos, width, height, Color.GREEN);
            ProjectileYPos--;
        }
    }
}


