using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace schoolTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int difficulty = 3;

            var readFile = new fileActions(difficulty.ToString());
            var words = new wordsActions();


            List<string> listReturned = readFile.readWords();

            foreach (var item in listReturned)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(words.listCount(listReturned).ToString());

            Console.ReadLine();
        }


        public enum difficulty
        {
            Easy, GotIt, SmashedIt
        }
    }
    //------------------------------END OF MAIN -------------------------------------------------------
    public class fileActions
    {
        public string fullPath;

        // constructor which will set fullPath to a File
        public fileActions(string wordNumber)
        {
            string makePath = @"Files\words" + wordNumber + ".txt";
            this.fullPath = makePath;

        }

        public List<string> readWords()
        {
            List<string> listOfWords = File.ReadAllLines(fullPath).ToList();

            return listOfWords;
        }


    }

    public class wordsActions
    {

        public int listCount(List<string> words)
        {
            List<string> countList = words;
            int count = countList.Count();
            return count;
        }


    }
}
