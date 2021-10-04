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
             *                                      apple (root)
             *                              
             *         APPLE(left)                                          mango(right)   
             *             
             * NULL(left)          MANGO(right)                    banana(left)        orange(right)
             * 
             *             NULL(left)          ORANGE(right)                     
             * 
             *
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.AddNode("apple");
            binarySearchTree.AddNode("APPLE");
            binarySearchTree.AddNode("mango");
            binarySearchTree.AddNode("MANGO");
            binarySearchTree.AddNode("orange");
            binarySearchTree.AddNode("ORANGE");
            binarySearchTree.AddNode("banana");
            Assert.IsTrue(binarySearchTree.Root.LeftNode.Word == "APPLE");
            Assert.IsTrue(binarySearchTree.Root.LeftNode.LeftNode == null);
            Assert.IsTrue(binarySearchTree.Root.LeftNode.RightNode.Word == "MANGO");
            Assert.IsTrue(binarySearchTree.Root.LeftNode.RightNode.LeftNode == null);
            Assert.IsTrue(binarySearchTree.Root.LeftNode.RightNode.RightNode.Word == "ORANGE");
            Assert.IsTrue(binarySearchTree.Root.RightNode.Word == "mango");
            Assert.IsTrue(binarySearchTree.Root.RightNode.RightNode.Word == "orange");
            Assert.IsTrue(binarySearchTree.Root.RightNode.LeftNode.Word == "banana");
        }
    }
}
*/