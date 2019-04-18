using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_SIgh
{
    class BinaryTree
    {
        private Node Root { get; set; }

        public int Height { get; set; }

        public int Count { get; set; }
        public void Print()
        {
            BinaryTreePrinter.printNode(Root);
        }
        #region Methods

        public void Insert(char val)
        {
            if (Root == null)
            {
                Root = new Node(val);
            }
            else
            {
                Insert(Root, val);
            }
        }
        private void Insert(Node Cur, char Val)
        {
            if(Val >= Cur.Value && Cur.RightChild == null)
            {
                Cur.RightChild = new Node(Val);
                return;
            }
            if (Val < Cur.Value && Cur.LeftChild == null)
            {
                Cur.LeftChild = new Node(Val);
                return;
            }
            if(Val >= Cur.Value)
            {
                Insert(Cur.RightChild, Val);
            }
            else if (Val < Cur.Value)
            {
                Insert(Cur.LeftChild, Val);
            }
        }
        public bool Remove(char val)
        {
            throw new NotImplementedException();
        }

        private bool Remove(Node val, char val2)
        {
            throw new NotImplementedException();
        }
        public bool Search(char val)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                return Search(Root, val);
            }
        }
        public bool Search(Node val, char val2)
        {
            if(Root == val)
            {
                return true;
            }
            else if(Root == )
        }
        public void PreOrderPrint()
        {
            throw new NotImplementedException();

        }
        private void PreOrderPrint(Node val)
        {
            throw new NotImplementedException();

        }
        public void InOrderPrint()
        {
            throw new NotImplementedException();

        }
        private void PreOderPrint(Node val)
        {
            throw new NotImplementedException();

        }
        public void PostOrderPrint()
        {
            throw new NotImplementedException();

        }
        private void PostOrderPrint(Node val)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
