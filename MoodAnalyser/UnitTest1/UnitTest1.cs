using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void GivenMoodHappy_ShouldReturnSad()
        {
            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers();
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("Sad", actual);
        }



        [TestMethod]
        public void GivenHAPPYMoodShouldReturnHappy()
        {

            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers("I am in Happy mood");
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("HAPPY", actual);
        }

        //T.C 3.1
        [TestMethod]
      
        public void GivenMoodEmpty_ShouldThrowException()
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

        //T.C 3.2
        [TestMethod]
        public void GivenMoodNull_ShouldThrowException()
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

        //T.C 4.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalysers(message);
            object obj = MoodAnalyserReflection.CreateMoodAnalyser("MoodAnalyser.MoodAnalysers", "MoodAnalysers");
            expected.Equals(obj);

        }

        //T.C 4.2
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]

        public void GivenWrongClassName_ShouldThrowException()
        {
            string message = null;
            object expected = new MoodAnalysers(message);
            object obj = MoodAnalyserReflection.CreateMoodAnalyser("MoodAnalyser.moodanalysers", "MoodAnalysers");
            expected.Equals(obj);

        }

        //T.C 4.3
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenClassConstructerNotProper_ShouldThrowException()
        {
            string message = null;
            object expected = new MoodAnalysers(message);
            object obj = MoodAnalyserReflection.CreateMoodAnalyser("MoodAnalyser.Moodanalysers", "MoodAnalysers(int)");
            expected.Equals(obj);

        }

        
    }
}
