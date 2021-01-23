using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System;
using Raylib_cs;
using System.Collections.Generic;

namespace NovemberProjekt
{
    public class Projectile
    {
        public bool exists = false;
        private int height = 10;
        private int width = 10;
        public float ProjectileYPos;
        public float ProjectileXPos;
        private float ProjectileSpeed = 8;
        public Rectangle hej;
        public static List<Projectile> allProjectiles = new List<Projectile>();
        public static void createProjektile(Projectile p){
            allProjectiles.Add(p);
        }
        private void fireProjectile(){
            exists = true;
        }
        public void update(){
            if (exists == false){
                hej = new Rectangle(ProjectileXPos, ProjectileYPos,  width, height);
                exists = true;
            }

            Raylib.DrawRectangleRec(hej, Color.RED);
            hej.y -= ProjectileSpeed;

            for (int i = 0; i < Meteorite.allMeteorites.Count; i++)
            {
                if (Raylib.CheckCollisionRecs(Meteorite.allMeteorites[i].hej, this.hej))
                {
                    Meteorite.allMeteorites.RemoveAt(i);
                    allProjectiles.Remove(this);
                }
            }
        }
    }
}


