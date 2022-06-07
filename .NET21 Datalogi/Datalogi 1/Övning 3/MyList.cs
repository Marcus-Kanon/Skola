using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    public class MyLinkedList<T>
    {
        private MyNode<T>? Head;
        public MyNode<T>? Current { get; set; }

        public void Push(T value)
        {
            Head = new MyNode<T>() { Data = value, Next = Head};
        }

        public void Next()
        {
            Current = Current.Next;
        }

        public T Get(int index)
        {
            var nodeReference = Current;
            for (int i = 0; i < index; i++)
            {
                nodeReference = nodeReference.Next;
            }
            return nodeReference.Data;
        }
    }
    public class MyNode<T>
    {
        public T Data { get; set; }
        public MyNode<T> Next { get; set; }
    }
}
