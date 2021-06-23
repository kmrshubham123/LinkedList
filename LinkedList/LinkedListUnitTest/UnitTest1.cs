using NUnit.Framework;
using LinkedList;

namespace LinkedListUnitTest
{
    public class Tests
    {
        [Test]
        //UC8-TC:-Search LinkedList to find the Node 
        public void SearchTheNode()
        {
            SingleLinkedList list = new SingleLinkedList();
            //Arrange
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Assert
            Node node = list.Search(30);
            //Act
            Assert.AreEqual(30, node.data);
        }
    }
}