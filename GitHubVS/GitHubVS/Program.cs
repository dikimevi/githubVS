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
            dikimevipersonel dper = new dikimevipersonel();
            Console.WriteLine("method: " + dper.dikimevi());
            mtalhak mtk = new mtalhak();
            Console.WriteLine("Ilk mesaj : " + mtk.ilk());
            Console.WriteLine("Awesome changes, pull request");
        }
    }
}
