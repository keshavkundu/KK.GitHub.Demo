/* 
 Created By:        Keshav Kundu
 Created Date:      02-10-2021
 Modified Date:     NA
 Purpose:           BinarySearchTree class methods are being used to add nodes in the search tree.
                    Store the string values in the tree and convert the tree to datatable.
 Referenced files:  GithubDemo.cs calls BinarySearchTree class and Node class by BinarySearchTree class
 */
using System;
using System.Collections.Generic;
using System.Data;
using KK.GitHub.Demo.ClassFiles.Constants;
using KK.GitHub.Demo.ClassFiles.Model;

namespace KK.GitHub.Demo.ClassFiles.LogicFiles
{
    /// <summary>
    /// The Node class to be used by BinarySearchTree class objects
    /// </summary>
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public string Word { get; set; }
        public int Count { get; set; } = 1;
    }

    /// <summary>
    /// Used by main program to add the nodes
    /// </summary>
    public class BinarySearchTree
    {
        private static readonly DataTable dtResultTable = new DataTable();
        private static readonly List<Word> dtResultList = new List<Word>();

        #region Public Accessed Objects and Methods

        public Node Root { get; set; }

        /// <summary>
        /// This method adds a string to root and increases count for same value if present in any node
        /// </summary>
        /// <param name="value"></param>
        /// <returns>This method returns true if a node is added else false if another node is found</returns>
        public bool AddNode(string value)
        {
            try
            {
                Node before = null, after = Root;
                while (after != null)
                {
                    before = after;
                    if (Sorting.AsciiSortStrings(value, after.Word) > 0) //for node in left node after
                        after = after.LeftNode;
                    else if (Sorting.AsciiSortStrings(value, after.Word) < 0) //for node in right node after
                        after = after.RightNode;
                    else
                    {
                        //Exist same value
                        Node sameNode = SearchValue(value);
                        if (sameNode != null)
                            sameNode.Count++; //Update the count of occurence
                        return false;
                    }
                }
                Node newNode = new Node
                {
                    Word = value
                };
                if (Root == null)
                    Root = newNode;
                else
                {
                    if (Sorting.AsciiSortStrings(value, before.Word) > 0) //For inseting in left node before
                        before.LeftNode = newNode;
                    else
                        before.RightNode = newNode; //For inserting in right node before
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Private Method

        /// <summary>
        /// Returns node of an object if Found
        /// </summary>
        /// <param name="value">String to be searched</param>
        /// <returns>Node else null</returns>
        private Node SearchValue(string value)
        {
            return this.SearchValue(value, this.Root);
        }

        /// <summary>
        /// Returns the node object if found
        /// </summary>
        /// <param name="value">Value needed to be searched in the node</param>
        /// <param name="parent">The root node where the value has to be searched</param>
        /// <returns>Node object if found else returns null</returns>
        private Node SearchValue(string value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Word) return parent; //If equal
                if (Sorting.AsciiSortStrings(value, parent.Word) > 0) //If value present in left node
                    return SearchValue(value, parent.LeftNode);
                else
                    return SearchValue(value, parent.RightNode); //If value present in right node
            }
            return null;
        }
        #endregion

        #region Public Static Methods
        /// <summary>
        /// This method is used to convert a binary tree node to DataTable
        /// </summary>
        /// <param name="parent">Node object or root</param>
        /// <returns>Datatable with coulmn CommentWord and Occurence</returns>
        public static DataTable convertBinaryTreeToDataTable(Node parent)
        {
            try
            {
                if (parent != null)
                {
                    convertBinaryTreeToDataTable(parent.LeftNode);
                    if (dtResultTable.Columns.Count == 0)
                    {
                        dtResultTable.Columns.Add(ApplicationConstants.firstColumn, typeof(string));
                        dtResultTable.Columns.Add(ApplicationConstants.secondColumn, typeof(int));
                    }
                    DataRow drRow = dtResultTable.NewRow();
                    drRow[0] = parent.Word;
                    drRow[1] = parent.Count;
                    dtResultTable.Rows.Add(drRow);
                    convertBinaryTreeToDataTable(parent.RightNode);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtResultTable;
        }

        /// <summary>
        /// This method is used to convert a binary tree node to List of Word object
        /// </summary>
        /// <param name="parent">Node object or root</param>
        /// <returns></returns>
        public static List<Word> convertBinaryTreeToList(Node parent)
        {
            try
            {
                if (parent != null)
                {
                    convertBinaryTreeToList(parent.LeftNode);
                    dtResultList.Add(new Word { CommentedWord = parent.Word, Occurence = parent.Count });
                    convertBinaryTreeToList(parent.RightNode);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtResultList;
        }

        #endregion
    }
}
