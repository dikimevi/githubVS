using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("commited by mtalhak");
            Console.WriteLine("commited by dikimevipersonel");
            mtalhak mtk = new mtalhak();
            Console.WriteLine("Ilk mesaj : " + mtk.ilk());
        }
    }
}
