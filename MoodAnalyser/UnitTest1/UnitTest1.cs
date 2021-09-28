using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers();
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("Sad", actual);
        }



        [TestMethod]
        public void TestMethod2()
        {

            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers("I am in Happy mood");
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("HAPPY", actual);
        }

        [TestMethod]
        public void TestMethod3()
        {

            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers(null);
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("Happy", actual);
        }
    }
}
