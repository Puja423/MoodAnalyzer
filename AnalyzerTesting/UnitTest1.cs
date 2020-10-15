using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace AnalyzerTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMood_ReturnSad()
        {
            string expected = "SAD";
            string message = "I am Sad now";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);

        }
    }
}
    


