using RPG2.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2.Graphics
{
    static public class MapWriter
    {
        static int Col
        {
            get
            {
                return col;
            }
            set
            {
                if (value < 0)
                    value = 0;
                col = value;
            }
        }
        public static int MapSize = 10000;
        public static int NumberOfBits { get; set; } = 7;
        public static int CameraWidth { get; set; } = 20;
        static public int CameraHeight { get; set; } = 17;
        static int col = 0;
        public static int[] map = new int[MapSize];
        public static List<IDrawable> EntityList;


        static MapWriter()
        {
            EntityList = new List<IDrawable>();
            Random rnd = new();

            for (int i = 0; i < MapSize; i++)
            {
                map[i] = rnd.Next(0, NumberOfBits);
            }
        }
        
        static bool CheckToDrawDrawable(int row, int i, out IDrawable ent)
        {
            foreach (var entity in EntityList)
            {
                if (entity != null)
                {
                    if (Col == entity.X && row >= entity.DrawRow && row < entity.DrawRow + entity.DrawHeight && i < entity.DrawWidth)
                    {
                        ent = entity;
                        return true;
                    }
                }
            }

            ent = new Monster();
            return false;
        }
        static bool CheckToDrawText(int row, int i, out IDrawable ent)
        {
            foreach (var entity in EntityList)
            {
                if (entity != null)
                {
                    if (Col == entity.X && row >= entity.DrawRow - entity.Text.Count && row < entity.DrawRow && i == 0 && entity.Text.Count > 0)
                    {
                        ent = entity;
                        return true;
                    }
                }
            }

            ent = new Monster();
            return false;
        }

        static public void DrawDrawables(IDrawable player)
        {
            Console.Clear();

            for (int row = 0; row < CameraHeight; row++)
            {
                int c = 0;
                for (Col = player.X - 10; (Col < player.X + 10 || Col < CameraWidth) && Col < MapSize; Col++)
                {
                    for (int i = 0; i < MapBits.Width; i++)
                    {
                        c++;
                        if (CheckToDrawText(row , i, out IDrawable textEnt)) //Draw Text above entity
                        {
                            Console.CursorLeft = c;

                            if (textEnt is Monster)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }

                            Console.Write(textEnt.Text[row-(textEnt.DrawRow - textEnt.Text.Count)]);
                        }


                        if (CheckToDrawDrawable(row, i, out IDrawable entity)) //Draw an entity
                        {
                            if (row >= entity.DrawRow)
                            {
                                int entityWritten = (row - entity.DrawRow) * entity.DrawWidth;
                                var entityBitToDraw = entity.Drawing;
                                var str = entityBitToDraw[entityWritten + i].ToString();

                                if(entity is Monster)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                }

                                Console.Write(str);
                            }
                        }
                        else //Draw environment instead
                        {
                            int envWritten = row * MapBits.Width;
                            var envBitToDraw = MapBits.mapBits[map[Col]];
                            string str = envBitToDraw.Drawing[envWritten + i].ToString();

                            Console.ForegroundColor = envBitToDraw.Color;
                            Console.Write(str);
                        }
                        


                    }
                }
                Console.WriteLine();
            }
        }

        static public void AddDrawable(IDrawable entity)
        {
            EntityList.Add(entity);
        }
    }
}
