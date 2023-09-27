namespace TestProject1Collections
{
    [TestClass]
    public class ListAlphabet1andListAlphabet2_resultEqual
    {
        [TestMethod]
        public void Compare_ListAlphabet1andListAlphabet2_resultEqual()
        {
            List<char> listAlphabet1 = new List<char>();
            listAlphabet1.Add('A');
            listAlphabet1.Add('B');
            listAlphabet1.Add('C');
            List<char> listAlphabet2 = new List<char>();
            listAlphabet2.Add('A');
            listAlphabet2.Add('B');
            listAlphabet2.Add('C');

            CollectionAssert.AreEqual(listAlphabet1, listAlphabet2);

        }
    }
}