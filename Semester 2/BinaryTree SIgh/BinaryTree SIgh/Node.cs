using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_SIgh
{
    class Node
    {
        public char Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Height
        {
            get
            {
                int LeftTreeHeight = 0;
                int RightTreeHeight = 0;

                if (LeftChild != null)
                {
                    LeftTreeHeight = LeftChild.Height + 1;
                }
                if (RightChild != null)
                {
                    RightTreeHeight = RightChild.Height + 1;
                }
                if (LeftTreeHeight > RightTreeHeight)
                {
                    return LeftTreeHeight;
                }
                else
                    return RightTreeHeight;

            }
        }
        public Node (char val)
        {
            Value = val;
        }
    }
}
