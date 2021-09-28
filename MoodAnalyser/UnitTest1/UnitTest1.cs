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
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void TestMethod3()
        {
            try
            {
                
                MoodAnalysers moodAnalyzer = new MoodAnalysers(" ");
                string mood = moodAnalyzer.AnalyserMethod();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            try
            {
                MoodAnalysers moodAnalyzer = new MoodAnalysers(null);
                string mood = moodAnalyzer.AnalyserMethod();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }

        }
    }
}
