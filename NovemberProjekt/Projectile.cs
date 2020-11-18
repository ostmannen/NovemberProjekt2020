using System;
using Raylib_cs;
using System.Collections.Generic;

namespace NovemberProjekt
{
    public class Projectile
    {

        public string name = "hej";
        private int projectileCount;
        private int height = 10;
        private int width = 10;
        private int ProjectileYPos;
        private int ProjectileXPos;
        public List<Projectile> allProjektiles = new List<Projectile>();
        public void createProjektile(){
            allProjektiles.Add(new Projectile());
        }
        public void fireProjectile(){
  
        }
    }
}


  /*    Projectile hej = new Projectile(){
                ProjectileYPos = 10, ProjectileXPos = 10
            };
            Raylib.DrawRectangle(xPos, yPos, width, height, Color.GREEN);
            hej.ProjectileYPos++;
            projectileCount++; */
