using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task1
{
    public class Module
    {
        public BTNode Activities = null;        // BST on ActID

        public void addActivity(Activity newOne)
        /* pre:  Have list of activities (Activities), 
         *       which could be empty.
         *       Have a new activity to add to the list.
         * post: Add the new activity to the list of activities, 
         *       maintaining a BST at all times. 
         *       Refer to pseudocode on pp 245 - 246 of recommended text. */
        {
            if (Activities == null)
                Activities = new BTNode(newOne);
            else
                addNode(newOne, Activities);
        }

        private void addNode(Activity newOne, BTNode T)
        {
            Activity curAct = (Activity)T.value();
            if (newOne.CompareTo(curAct) <= 0)
                if (T.left() == null)
                    T.setLeft(new BTNode(newOne));
                else
                    addNode(newOne, T.left());
            else
                if (T.right() == null)
                    T.setRight(new BTNode(newOne));
                else
                    addNode(newOne, T.right());
        }

        public void displayAscending()
        /* pre:  Have list of activities (Activities), 
         *       which could be empty.
         * post: Display activities in ascending order of activity identifier. */
        {
            doDispAsc(Activities); // initial recursive so for inorder transversal of the tree  since it displays the left child then the root of the tree or subtree
                                   // then the right child  by doing it displays the BTS in ascending order 
    
        }
        private void doDispAsc(BTNode T)
        {
            if (T != null) // return if T==null  since the  tranversal of the tree would be finished 
            {
                Activity cur = (Activity)T.value();
                doDispAsc(T.left());    //display left child first
                cur.display();         
                doDispAsc(T.right());    //display right child last
            }
        }

        public Activity findMin()
        /* pre:  Have list of activities (Activities), 
         *       which could be empty.
         * post: EFFICIENTLY find and return the activity
         *       with the smallest activity identifier. */
        {
            BTNode t = Activities;
            while (t.left() != null)   // when t.left()==null then t is the left most child as such t is the node with the  smallest activity identifier
            {
                t = t.left();          //then t =t.left() till t.left()==null  (t is equal to the next left child till the are no more left children)
            }
            Activity tt = (Activity)t.value();      //after the while loop we have found the node and return its value  as an activity
            return tt;                

        }

        public int height()
        /* pre:  Have list of activities (Activities), 
         *       which could be empty.
         * post: Determine and return the height
         *       of the tree Activities. */
        {
            return h(Activities)-1; // initial recursive call
                                    // the height is equal to level of tree minus 1
        }
        private int h(BTNode T)
        {
            if (T == null) 
            {
                return 0;
            }
            else
            {
                return 1+ Math.Max(h(T.right()), h(T.left())); // level of tree is determined of the tree is determined and returned
            }
        }
    }
}




