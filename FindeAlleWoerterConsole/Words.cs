using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FindeAlleWoerterConsole
{
    class Words
    {
        public List<string> Data = File.ReadAllLines("Data\\WordList.txt").ToList();


    }
}
