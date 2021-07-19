using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyser moodAnalyser;
        string message = " I am happy";
        [TestInitialize]
        public void SetUp()
        {
            moodAnalyser = new MoodAnalyser(message);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "happy";

            string actual = moodAnalyser.Mood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "sad";
            moodAnalyser = new MoodAnalyser("i am sad");
            string actual = moodAnalyser.Mood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodNull()
        {
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am happy");
            string actual = moodAnalyser.Mood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForCustomizedNullException()
        {
            string expected = "Mood should not be null";
            try
            {

                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                moodAnalyser.Mood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void TestMethodForCustomizedEmptyException()

        {
            string expected = "Mood should not be empty";
            try
            {

                MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);
                moodAnalyser.Mood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
