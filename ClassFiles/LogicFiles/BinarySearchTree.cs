
using System.Data;
namespace KK.GitHub.Demo.ClassFiles.LogicFiles
{
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public string Data { get; set; }
        public int Count { get; set; } = 1;
    }

    class BinarySearchTree
    {
        public string Result = string.Empty;
        public static DataTable dtResultTable = new DataTable();
        public Node Root { get; set; }

        public bool AddNode(string value)
        {
            Node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                if (Sorting.AsciSortStrings(value, after.Data) == 1) //for node in left node after
                    after = after.LeftNode;
                else if (Sorting.AsciSortStrings(value, after.Data) == -1) //for node in right node after
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    Node sameNode = SearchValue(value);
                    if (sameNode != null)
                        sameNode.Count = sameNode.Count + 1; //Update the count of occurence
                    return false;
                }
            }
            Node newNode = new Node();
            newNode.Data = value;
            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (Sorting.AsciSortStrings(value, before.Data) == 1) //For inseting in left node before
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode; //For inserting in right node before
            }
            return true;
        }

        public Node SearchValue(string value)
        {
            return this.SearchValue(value, this.Root);
        }

        private Node SearchValue(string value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent; //If equal
                if (Sorting.AsciSortStrings(value, parent.Data) == 1) //If value present in left node
                    return SearchValue(value, parent.LeftNode);
                else
                    return SearchValue(value, parent.RightNode); //If value present in right node
            }
            return null;
        }
        public string PrintValues(Node parent)
        {
            if (parent != null)
            {
                PrintValues(parent.LeftNode);
                Result = Result + parent.Data + ":" + parent.Count.ToString() + "|";
                PrintValues(parent.RightNode);
            }
            return Result;
        }

        public static DataTable convertBinaryTreeToDataTable(Node parent)
        {
            if (parent != null)
            {
                convertBinaryTreeToDataTable(parent.LeftNode);
                if (dtResultTable.Columns.Count == 0)
                {
                    dtResultTable.Columns.Add("CommentWord", typeof(string));
                    dtResultTable.Columns.Add("Occurence", typeof(int));
                }
                DataRow drRow = dtResultTable.NewRow();
                drRow[0] = parent.Data;
                drRow[1] = parent.Count;
                dtResultTable.Rows.Add(drRow);
                convertBinaryTreeToDataTable(parent.RightNode);
            }
            return dtResultTable;
        }
    }
}
