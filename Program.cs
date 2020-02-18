using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class counting
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            string[] Words = inp.Split(' ');
            Dictionary<string, int> data = new Dictionary<string, int>();
            for (int n = 0; n < Words.Length; ++n)
            {
                String temp = Words[n];
                if (data.ContainsKey(temp))
                {
                    data[temp] = data[temp] + 1;
                }
                else
                {
                    data.Add(temp, 1);
                }
            }
            foreach (string n in data.Keys)
            {
                Console.WriteLine("Word:{0} - Freq:{1}", n, data[n]);
            }
        }
    }
}