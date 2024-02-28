namespace _056_Kata
{
    public class Tests
    {

        [Test]
        public void PotnijTest()
        {
            var StringTestowy = "to jest taki tam test";
            var rezultat = Kata.Potnij(StringTestowy,' ');

            Assert.AreEqual("test", rezultat[4]);
            Assert.AreEqual("tam", rezultat[3]);
            Assert.AreEqual("taki", rezultat[2]);
            Assert.AreEqual("jest", rezultat[1]);
            Assert.AreEqual("to", rezultat[0]);
        }

        [Test]
        public void ObrocTest()
        {
            var TablicaTestowa = new List<string>()
            {
                "to", "jest", "taki", "tam", "test"
            };
            var rezultat = Kata.Obroc(TablicaTestowa);

            Assert.AreEqual(TablicaTestowa[0], rezultat[4]);
            Assert.AreEqual(TablicaTestowa[1], rezultat[3]);
            Assert.AreEqual(TablicaTestowa[2], rezultat[2]);
            Assert.AreEqual(TablicaTestowa[3], rezultat[1]);
            Assert.AreEqual(TablicaTestowa[4], rezultat[0]);
        }

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
            Assert.AreEqual("", Kata.ReverseWords(""));
        }
    }
}