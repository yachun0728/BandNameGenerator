using BandNameGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BandNameGeneratorTests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void Input_knife_will_get_The_Knife()
        {
            Assert.AreEqual("The Knife", Kata.BandNameGenerator("knife"));
        }

        [TestMethod()]
        public void Input_tart_will_get_Tartart()
        {
            Assert.AreEqual("Tartart", Kata.BandNameGenerator("tart"));
        }

        [TestMethod()]
        public void Input_sandles_will_get_Sandlesandles()
        {
            Assert.AreEqual("Sandlesandles", Kata.BandNameGenerator("sandles"));
        }

        [TestMethod()]
        public void Input_bed_will_get_The_Bed()
        {
            Assert.AreEqual("The Bed", Kata.BandNameGenerator("bed"));
        }
    }
}
