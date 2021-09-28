using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to MoodAnalyses Problem-------------");
            MoodAnalysers analyser = new MoodAnalysers("I am in any mood");
            Console.WriteLine(analyser.AnalyserMethod());
        }
    }
}
