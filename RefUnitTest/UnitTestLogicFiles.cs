/*
using KK.GitHub.Demo.ClassFiles.LogicFiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KK.GitHub.Demo.Tests
{
    [TestClass]
    public class UnitTestLogicFiles
    {
        /// <summary>
        /// [TestMethod] for checking if the left string is in ascending order
        /// </summary>
        [TestMethod]
        public void TestSortingLeft()
        {
            int result = Sorting.AsciiSortStrings("0123", "M123");
            Assert.IsTrue(result > 0);
        }

        /// <summary>
        /// [TestMethod] for checking if the right string is in ascending order
        /// </summary>
        [TestMethod]
        public void TestSortingRight()
        {
            int result = Sorting.AsciiSortStrings("abc", "Abc");
            Assert.IsTrue(result < 0);
        }

        /// <summary>
        /// [TestMethod] for checking if both the strings are equal
        /// </summary>
        [TestMethod]
        public void TestSortingEquals()
        {
            int result = Sorting.AsciiSortStrings("012abc", "012abc");
            Assert.IsTrue(result == 0);
        }

        /// <summary>
        /// [TestMethod] for checking insertion in binary tree
        /// </summary>
        [TestMethod]
        public void TestAddingNode()
        {
             //                                     apple (root)
             //         APPLE(left)                                          mango(right)   
             //            
             // NULL(left)          MANGO(right)                    banana(left)        orange(right)
             // 
             //             NULL(left)          ORANGE(right)                     
             //
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.AddNode("apple");
            binarySearchTree.AddNode("APPLE");
            binarySearchTree.AddNode("mango");
            binarySearchTree.AddNode("MANGO");
            binarySearchTree.AddNode("orange");
            binarySearchTree.AddNode("ORANGE");
            binarySearchTree.AddNode("banana");
            Assert.AreEqual("apple", binarySearchTree.Root.Word);
            Assert.AreEqual("APPLE", binarySearchTree.Root.LeftNode.Word);
            Assert.IsTrue(binarySearchTree.Root.LeftNode.LeftNode == null);
            Assert.AreEqual("MANGO", binarySearchTree.Root.LeftNode.RightNode.Word);
            Assert.IsTrue(binarySearchTree.Root.LeftNode.RightNode.LeftNode == null);
            Assert.AreEqual("ORANGE", binarySearchTree.Root.LeftNode.RightNode.RightNode.Word);
            Assert.AreEqual("mango", binarySearchTree.Root.RightNode.Word);
            Assert.AreEqual("orange", binarySearchTree.Root.RightNode.RightNode.Word);
            Assert.AreEqual("banana", binarySearchTree.Root.RightNode.LeftNode.Word);
        }

        /// <summary>
        /// [TestMethod] for checking Bubble Sort is working based on ASCII values
        /// </summary>
        [TestMethod]
        public void TestingBubbleSort()
        {
            List<Word> words = new List<Word>();
            words.Add(new Word() { CommentedWord = "apple", Occurence = 2 });
            words.Add(new Word() { CommentedWord = "APPLE", Occurence = 1 });
            words.Add(new Word() { CommentedWord = "mango", Occurence = 3 });
            words.Add(new Word() { CommentedWord = "ORANGE", Occurence = 4 });
            DataTable dataTable = words.sortAndBindListToDataTable();
            Assert.IsTrue(dataTable.Rows[0][0].ToString() == "APPLE" && Convert.ToInt32(dataTable.Rows[0][1]) == 1);
            Assert.IsTrue(dataTable.Rows[1][0].ToString() == "ORANGE" && Convert.ToInt32(dataTable.Rows[1][1]) == 4);
            Assert.IsTrue(dataTable.Rows[2][0].ToString() == "apple" && Convert.ToInt32(dataTable.Rows[2][1]) == 2);
            Assert.IsTrue(dataTable.Rows[3][0].ToString() == "mango" && Convert.ToInt32(dataTable.Rows[3][1]) == 3);
        }
    }
}
*/