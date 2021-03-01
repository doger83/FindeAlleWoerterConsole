using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindeAlleWoerterConsole
{
    class WordFinder
    {
        private string baseWord;
        private Words germanWords = new Words();
        private List<string> possibleWords = new List<string>();
        private List<string> permutations;
        private int possibleWordsCounter = 0;
        private char[] baseCharacters;

        public void PrintAllWord()
        {
            foreach (var word in germanWords.Data)
            {
                Console.WriteLine(word);
            }
        }
        public void AskForNewWord()
        {
            Console.WriteLine("Geben Sie bitte das Suchwort ein: ");
            baseWord = Console.ReadLine();
            baseCharacters = new char[baseWord.Length];
            Console.WriteLine(containsBasis());

        }

        internal void PrintPossibleWords()
        {
            foreach (var word in possibleWords)
            {
                Console.WriteLine(word);
            }
        }

        internal void FindPossibleWords()
        {
            permutations = Permute(baseWord).ToList();

            foreach (var word in permutations)
            {
                if (germanWords.Data.Contains(word))
                {
                    possibleWordsCounter++;
                    possibleWords.Add(word);
                }
            }

            //foreach (var word in germanWords.Data)
            //{
            //    if (word == baseWord)
            //    {
            //        possibleWords.Add(word);
            //        possibleWordsCounter++;

            //    }
            //}

        }

        private static IEnumerable<string> Permute(string target)
        {
            if (target.Length <= 1)
            {
                yield return target;
                yield break;
            }
            var c = target[0];
            foreach (var rest in Permute(target.Remove(0, 1)))
            {
                yield return c + rest;
                yield return c + " " + rest;
            }
        }

        internal void PrintPossibleWordsCounter()
        {
            Console.WriteLine(possibleWordsCounter);
        }

        private bool containsBasis()
        {
            return germanWords.Data.Contains(baseWord);
        }
    }
}
