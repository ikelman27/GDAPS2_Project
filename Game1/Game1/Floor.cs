﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Game1
{
    class Floor
    {
        public Room[,] floorLayout;
        public Room currentRoom; //the room the player is in
                                 // public Room defaultRoom; //a default room that loads the textures from
        int depth;
        int x = 1;
        int y = 1;

        public int floorNum;


        public Floor(int width, int height, int level)
        {
            floorLayout = new Room[height + 2, width + 2];
            createFloor();
            currentRoom = floorLayout[1, 1];
            depth = level;
            //defaultRoom = new Room();
            floorNum = 1;

        }

        void createRoom(int i, int j)
        {
            floorLayout[i, j] = new Room(j, i);
            floorLayout[i, j].isCleared = false;
            floorLayout[i, j].SetWalls();
        }

        void createFloor()
        {
            for (int i = 1; i < floorLayout.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < floorLayout.GetLength(1) - 1; j++)
                {
                    createRoom(i, j);
                }
            }
        }

        public void drawFloor(Texture2D hWall, Texture2D vWall, Texture2D hDoor, Texture2D vDoor)
        {
            for (int i = 1; i < floorLayout.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < floorLayout.GetLength(1) - 1; j++)
                {
                    if (floorLayout[i, j] != null)
                    {
                        floorLayout[i, j].SetWallTexture(hWall, vWall);
                        floorLayout[i, j].SetDoorSprite(vDoor, hDoor);
                    }
                }
            }
        }


        public bool checkLeftDoor(int i, int j)
        {
            if (floorLayout[i, j - 1] != null)
            {
                return true;

            }
            else { return false; }
        }

        public bool checkUpperDoor(int i, int j)
        {

            if (floorLayout[i - 1, j] != null)
            {

                return true;
            }
            else { return false; }
        }

        public bool checkLowerDoor(int i, int j)
        {

            if (floorLayout[i + 1, j] != null)
            {
                return true;
            }
            else { return false; }
        }

        public bool checkRightDoor(int i, int j)
        {

            if (floorLayout[i, j + 1] != null)
            {
                return true;

            }

            else { return false; }
        }

        public Room enterDoor(Character mainChar)
        {
            bool intersectDoor = false;

            if (currentRoom.RoomClear())
            {


                floorLayout[x, y] = currentRoom;


                if (currentRoom.bottomDoor != null)
                {
                    if (currentRoom.CRIntersect(mainChar.loc, currentRoom.bottomDoor.exitBox))
                    {
                        mainChar.loc.Center.X = 800;
                        mainChar.loc.Center.Y = 50 + mainChar.loc.Radius;
                        y++;
                        intersectDoor = true;
                    }
                }
                if (currentRoom.topDoor != null)
                {
                    if (currentRoom.CRIntersect(mainChar.loc, currentRoom.topDoor.exitBox))
                    {
                        mainChar.loc.Center.X = 800;
                        mainChar.loc.Center.Y = 850 - mainChar.loc.Radius;
                        y--;
                        intersectDoor = true;
                    }
                }
                if (currentRoom.rightDoor != null)
                {
                    if (currentRoom.CRIntersect(mainChar.loc, currentRoom.rightDoor.exitBox))
                    {
                        mainChar.loc.Center.X = 50 + mainChar.loc.Radius;
                        mainChar.loc.Center.Y = 450;
                        x++;
                        intersectDoor = true;
                    }
                }
                if (currentRoom.leftDoor != null)
                {
                    if (currentRoom.CRIntersect(mainChar.loc, currentRoom.leftDoor.exitBox))
                    {
                        mainChar.loc.Center.X = 1550 - mainChar.loc.Radius;
                        mainChar.loc.Center.Y = 450;
                        x--;
                        intersectDoor = true;
                    }
                }

                if (!intersectDoor)
                {
                    mainChar.loc.Center.X = 800;
                    mainChar.loc.Center.Y = 100;
                    floorLayout[x, y].isCleared = false;
                    x = 1;
                    y = 1;
                    
                }

                return enterRoom();
            }

            return currentRoom;

        }
        public Room enterRoom()
        {

            Room currentRoom = floorLayout[x, y];
            return currentRoom;

        }

        public bool isFloorClear()
        {
            bool floorClear = true;
            for (int i = 1; i < floorLayout.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < floorLayout.GetLength(1) - 1; j++)
                {
                    if (floorLayout[i, j] != null)
                    {
                        if (!floorLayout[i, j].isCleared)
                            floorClear = false;
                    }
                }
            }
            if (floorClear)
                return true;

            return false;
        }

        public void changeFloors()
        {
            
            for (int i = 1; i < floorLayout.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < floorLayout.GetLength(1) - 1; j++)
                {
                    if (floorLayout[i, j] != null)
                    {
                        floorLayout[i, j].isCleared = false;
                        floorLayout[i, j].drops = new List<Collectible>();
                    }
                }
            }
            floorNum++;
            
            
        }
    }
}


