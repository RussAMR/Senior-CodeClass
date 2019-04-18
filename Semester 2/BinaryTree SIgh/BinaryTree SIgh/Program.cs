using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_SIgh
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binarytree = new BinaryTree();
            binarytree.Insert('m');
            binarytree.Insert('t');
            binarytree.Insert('p');
            binarytree.Insert('q');
            binarytree.Insert('a');
            binarytree.Insert('z');
            binarytree.Print();
        }
    }
}
