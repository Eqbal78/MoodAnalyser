using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow("I am in sad mood")]
        [TestMethod]
        public void TestMethod1(string message)
        {
            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers(message);
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("Sad", actual);
        }

        
        [DataRow("I am in any mood")]
        [TestMethod]
        public void TestMethod2(string message)
        {
           
            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers(message);
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("Happy", actual);
        }
    }
}
