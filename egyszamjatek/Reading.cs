using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace egyszamjatek
{
    internal class Reading
    {
        public int[] tips = new int[10];
        public string name;
        public Reading(string line)
        {
            string[] data = line.Split(' ');
            for (int i = 0; i < tips.Length; i++)
            {
                tips[i] = int.Parse(data[i]);
            }
            name = data[data.Length-1];
        } 
    }
}
