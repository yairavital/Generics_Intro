using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19
{
    internal class HeroesTable<T> where T : Knight
    {
        Knight[] knights { get; set; }
        public Knight this[int index]
        {
            get
            {
                if (CountKnights() == 0)
                    return null;
                else if (CountKnights() <= index - 1)
                {
                    if (knights[index] == null)
                    {
                        for (int i = index - 1; i >= 0; i--)
                        {
                            if (knights[i] != null)
                                return knights[i];

                        }
                    }
                    return knights[index];
                }
                else
                { 
                    return knights[index%knights.Length];
                }



            }
            set { }
        }

        public HeroesTable(int length)
        {
            knights = new Knight[length];
        }
        public void Set(int index, Knight knight)
        {
            knights[index] = knight;
        }
        public void Delete(int index)
        {
            knights[index] = null;
        }
        public int CountKnights()
        {
            int count = 0;
            foreach (Knight knight in knights)
            {
                if (knight != null)
                    count++;
            }

            return count;
        }
        public Knight[] knightsL()
        {
            List<Knight> knightsList = new List<Knight>();
            foreach (Knight knight in knights)
            {
                if (knight != null)
                    knightsList.Add(knight);

            }
            return knightsList.ToArray();
        }
    }
}
