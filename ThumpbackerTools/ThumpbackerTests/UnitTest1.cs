using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ThumpbackerTools.Math;

namespace ThumpbackerTests
{
    [TestClass]
    public class UnitTest1
    {
        public MathT math = new MathT();

        [TestMethod]
        public void TestMedian()
        {
            List<int> medianList = new List<int> { 3, 22, 1, 19, 12 };

            float median = math.Median(medianList);

            Assert.IsTrue(median == 12, "Median was " + median);
        }

        [TestMethod]
        public void TestMode()
        {
            List<int> modeList = new List<int> { 3, 22, 1, 19, 12, 22, 3};

            List<int> mode = math.Mode(modeList);

            string modeStr = "";

            foreach (var m in mode)
            {
                modeStr += m + " ";
            }

            Assert.IsTrue(mode[0] == 3 && mode[1] == 22, "Mode was " + modeStr);
        }

        [TestMethod]
        public void TestMean()
        {
            List<int> meanList = new List<int> { 3, 22, 1, 19, 12 };

            float mean = math.Mean(meanList);

            Assert.IsTrue(mean == 11.4, "Mean was " + mean);
        }
    }
}
