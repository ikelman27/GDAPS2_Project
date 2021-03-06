﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{

     public class Character
    {
        
        public double healthPoints;
        public double maxHP;
        public double attackDamage;
        public int XP;
        public int level;
        public double moveSpeed;
        public Texture2D sprite;
        public Vector2 origin;
        public Circle loc;
        public int enemiesKilled = 0;



        public Character()
        {
            
        }
        public Character(int x, int y, float radius)
        {
            loc = new Circle(new Vector2(x, y), radius);
            XP = -1;
        }
        public void SetSprite(Texture2D text)
        {
            sprite = text;
            loc.Radius = sprite.Width / 2;
            origin.X = sprite.Width / 2;
            origin.Y = sprite.Height / 2;
        }

        public Texture2D getSprite()
        {
            return sprite;
        }

        public static void charHit(Character attacker, Character defender)
        {
            float rotate = getAngleBetween(defender, attacker);
            if (attacker.loc.Center.X > defender.loc.Center.X)
                defender.loc.Center.X -= 100 * (float)Math.Pow(Math.Sin(rotate), 2);
            else if (attacker.loc.Center.X < defender.loc.Center.X)
                defender.loc.Center.X += 100 * (float)Math.Pow(Math.Sin(rotate), 2);
            if (attacker.loc.Center.Y > defender.loc.Center.Y)
                defender.loc.Center.Y -= 100 * (float)Math.Pow(Math.Cos(rotate), 2);
            else if (attacker.loc.Center.Y < defender.loc.Center.Y)
                defender.loc.Center.Y += 100 * (float)Math.Pow(Math.Cos(rotate), 2);

            defender.healthPoints -= attacker.attackDamage;            
            if(defender.healthPoints<=0 && attacker.XP!=-1) 
            {
                attacker.XP += 10;
            }


        }
        public bool CheckXP()
        {
            if (this.XP>=(50*level)+(100*(level-1)))
            {
                level++;
                XP = 0;
                return true;
                
            }
            return false;
        }

        public static float getAngleBetween(Character c1, Character c2)
        {
            float xdist = c1.loc.Center.X - c2.loc.Center.X;
            float ydist = c1.loc.Center.Y - c2.loc.Center.Y;
            float rotate = (float)(System.Math.Atan2(ydist, xdist) + 1.570);
            return rotate;
        }

        //Checks if the character is off the screen
        public static void offScreen(Character c1)
        {
            if(c1.loc.Center.X < 0)
            {
                c1.loc.Center.X = 100;
            }
            if(c1.loc.Center.Y < 0)
            {
                c1.loc.Center.Y = 100;
            }
            
        }
    }

}

