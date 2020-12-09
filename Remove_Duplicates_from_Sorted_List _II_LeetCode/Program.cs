using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_List__II_LeetCode
{
    class Program
    {

        public class Node
        {
            public int val;
            public Node next;
            public Node(int data)
            {
                val = data;
                next = null;
            }
        }

        public class LinkedList
        {
            Node root;

            public LinkedList()
            {
                root = null;
            }

            public void insertNode(int data)
            {
                Node newNode = new Node(data);
                if (this.root != null)
                {
                    newNode.next = root;
                }
                this.root = newNode;
            }

            public Node returnNode()
            {
                return root;
            }

            public void showList(Node root)
            {
                Node temp = root;
                while (temp != null)
                {
                    Console.Write(temp.val + " ");
                    temp = temp.next;
                }
            }

            //Remove Dublicate from sorted List
            public Node RemoveDublicateFromSortedList(Node root)
            {
                if (root == null|| root.next == null) 
                { return root; }
                else
                {
                    Node newroot = new Node(0);
                    newroot.next = root;

                    Node curr,p,q;
                    int flag = 0;

                    curr = newroot;
                    p = newroot.next;
                    q = newroot.next.next;

                    while(q !=null)
                    {
                        if(p.val == q.val)
                        {
                            if (q.next == null)
                            {
                                curr.next = q.next;
                                q = q.next;
                            }
                            else
                            {
                                q = q.next;
                                flag = 1;
                            }
                        }
                        else if(flag == 0)
                        {
                            curr = curr.next;
                            p = p.next;
                            q = q.next;
                        }
                        else if(flag !=0)
                        {
                            curr.next = q;
                            p = curr.next;
                            q = p.next;
                            flag = 0;
                        }
                    }

                    return newroot.next;
                }
                

            }

            ////////////////////////////
        }
        static void Main(string[] args)
        {
            LinkedList ls = new LinkedList();
            //ls.insertNode(6);
            //ls.insertNode(5);
            //ls.insertNode(5);
            //ls.insertNode(5);
            //ls.insertNode(4);
            //ls.insertNode(3);
            //ls.insertNode(3);
            //ls.insertNode(2);
            //ls.insertNode(1);

            ls.insertNode(6);
            ls.insertNode(6);
            ls.insertNode(5);
            ls.insertNode(5);
            ls.insertNode(5);
            ls.insertNode(4);
            ls.insertNode(3);
            ls.insertNode(3);
            ls.insertNode(2);
            ls.insertNode(1);


            Node returnNode = ls.returnNode();
            ls.showList(returnNode);
            Console.WriteLine("");

            ls.RemoveDublicateFromSortedList(returnNode);
            ls.showList(returnNode);
            Console.ReadLine();
        }
    }
}
