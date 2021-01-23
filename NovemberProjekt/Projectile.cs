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
        public Rectangle projectileRec;
        public static List<Projectile> allProjectiles = new List<Projectile>();
        public static void createProjektile(Projectile p){
            allProjectiles.Add(p);
        }
        private void fireProjectile(){
            exists = true;
        }
        public void update(){
            if (exists == false){
                projectileRec = new Rectangle(ProjectileXPos, ProjectileYPos,  width, height);
                exists = true;
            }

            Raylib.DrawRectangleRec(projectileRec, Color.RED);
            projectileRec.y -= ProjectileSpeed;

            for (int i = 0; i < Meteorite.allMeteorites.Count; i++)
            {
                if (Raylib.CheckCollisionRecs(Meteorite.allMeteorites[i].meteoriteRec, this.projectileRec))
                {
                    Meteorite.allMeteorites.RemoveAt(i);
                    allProjectiles.Remove(this);
                }
            }
        }
    }
}


