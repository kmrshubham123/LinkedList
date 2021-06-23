using NUnit.Framework;
using LinkedList;

namespace LinkedListUnitTest
{
    public class Tests
    {
        SingleLinkedList list = new SingleLinkedList();
        [Test]
        //UC7-TC:-Search LinkedList to find the Node 
        public void SearchTheNode()
        {
            //Arrange
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Assert
            Node node = list.Search(30);
            //Act
            Assert.AreEqual(30, node.data);
        }
        [Test]
        //UC8-TC:-insert 40 after 30 to the Linked List
        public void InsertNodeAfterTheNode()
        {
            //Arrange
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Assert
            list.InsertBetweenPosition(2, 40);
            Node node = list.Search(40);
            //Act
            Assert.AreEqual(40, node.data);
        }
    }
}