using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibcs
{
    public class MyXorList
    {

        public class Node
        {
            public MyData data;
            public Node next;
            public Node prev;
        }

        public Node head;

        public MyXorList()
        {
            head = new Node();
            head.next = head;
            head.prev = head;
        }

        /// <summary>
        /// Put data in the list's beginning.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public void insertFront(MyData data)
        {
            Node node = new Node();
            node.data = data;
            node.next = head.next;
            node.prev = head;
            head.next.prev = node;
            head.next = node;
        }

        /// <summary>
        /// List End Data Insert
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int insertEnd(MyData data)
        {
            Node node = new Node();
            node.data = data;
            node.next = head;
            node.prev = head.prev;
            head.prev.next = node;
            head.prev = node;

            return data.key;
        }
        /// <summary>
        /// List Search and Data Removal By Key Value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int removeByKey(MyData data)
        {
            Node node = head.next;
            Node prev = head;
            Node next = head.next.next;
            while (node != head)
            {
                if (node.data.key == data.key)
                {
                    prev.next = next;
                    next.prev = prev;
                    return data.key;
                }
                prev = node;
                node = next;
                next = next.next;
            }
            return -1;
        }

        /// <summary>
        /// Place Data After Items With Key Parameters
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int insertAfter(MyData data, int key)
        {
            Node node = head.next;
            Node prev = head;
            Node next = head.next.next;
            while (node != head)
            {
                if (node.data.key == key)
                {
                    Node newNode = new Node();
                    newNode.data = data;
                    newNode.next = next;
                    newNode.prev = node;
                    node.next = newNode;
                    next.prev = newNode;
                    return data.key;
                }
                prev = node;
                node = next;
                next = next.next;
            }
            return -1;
        }

        /// <summary>
        /// Provide List as a Data Array.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public MyData[] list()
        {
            List<MyData> list = new List<MyData>();
            Node node = head.next;
            while (node != head)
            {
                list.Add(node.data);
                node = node.next;
            }
            return list.ToArray();
        }

        /// <summary>
        /// List Search with Key-Return Data
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public MyData searchByKey(int key)
        {
            Node node = head.next;
            while (node != head)
            {
                if (node.data.key == key)
                {
                    return node.data;
                }
                node = node.next;
            }
            return null;
        }
    }
}
