namespace TestProject2Collections
{
    [TestClass]
    public class ListAlphabet1andListAlphabet2_resultEquivalent
    {
        [TestMethod]
        public void Compare_ListAlphabet1andListAlphabet2_resultEquivalent()
        {
            List<char> listAlphabet1 = new List<char>();
            listAlphabet1.Add('B');
            listAlphabet1.Add('A');
            listAlphabet1.Add('C');
            List<char> listAlphabet2 = new List<char>();
            listAlphabet2.Add('C');
            listAlphabet2.Add('A');
            listAlphabet2.Add('B');

            CollectionAssert.AreEquivalent(listAlphabet1, listAlphabet2);
        }
    }
}