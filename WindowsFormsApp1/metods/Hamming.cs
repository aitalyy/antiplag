using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.metods
{
    internal class Hamming
    {
        public int HammingDistance(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return 0;
            }

            int distance = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                {
                    distance++;
                }
            }

            return distance;
        }
    }
}
