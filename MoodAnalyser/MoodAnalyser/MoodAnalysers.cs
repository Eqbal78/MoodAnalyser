using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalysers
    {
        public string message;

        /// <summary>
        /// Non-Parameterised Constructor
        /// </summary>
        public MoodAnalysers()
        {
            this.message = "I am in Sad mood";
        }

        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalysers(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Mood Analyser check Happy or sad
        /// </summary>
        /// <returns></returns>
        public string AnalyserMethod()
        {
            try
            {
                if (this.message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "Happy";
            }
        }
    }
}
