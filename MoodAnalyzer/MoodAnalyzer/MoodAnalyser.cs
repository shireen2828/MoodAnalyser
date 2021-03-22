using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzer
    {
        private string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public MoodAnalyzer()
        {
        }
        public string analyseMoodLive1()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
