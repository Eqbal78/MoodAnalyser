using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to MoodAnalyses Problem-------------");
            MoodAnalysers analyser = new MoodAnalysers("I am in sad Mood");
            Console.WriteLine(analyser.AnalyserMethod());
        }
    }
}
