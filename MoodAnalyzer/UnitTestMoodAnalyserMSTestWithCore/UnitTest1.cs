using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace UnitTestMoodAnalyserMSTestWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
        }
    }
   
}
