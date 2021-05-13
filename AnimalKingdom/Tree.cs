using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdom
{
    class Tree
    {
        public int count { get; set; }

        public Tree(int treecount) {
            this.count = treecount ;
        }


        public int Remaining_Tree()
        {
            return count--;  
        }
    }
}
