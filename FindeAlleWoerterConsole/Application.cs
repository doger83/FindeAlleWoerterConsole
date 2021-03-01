using System;
using System.Collections.Generic;
using System.Text;

namespace FindeAlleWoerterConsole
{
    class Application
    {
        private bool continueRunning;
        private WordFinder wordFinder = new WordFinder();
        public void Run()
        {
            continueRunning = true;
            while (continueRunning)
            {
                wordFinder.AskForNewWord();
                wordFinder.FindPossibleWords();
                wordFinder.PrintPossibleWords();
                wordFinder.PrintPossibleWordsCounter();
                //wordFinder.PrintAllWord();
                continueRunning = false;
            }
        }

        public void Close()
        {
            Console.WriteLine("Hit ENTER to close the App..");
            Console.ReadKey(true);
        }
    }
}
