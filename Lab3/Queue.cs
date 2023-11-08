using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Cui 20230426
//This Queue is implemented by a double linked list
namespace Lab3
{
    public class QueueException : System.Exception
    {
        public QueueException(string strMessage) : base(strMessage) { }
    }
    internal class Queue<T> where T: IEquatable<T>
    {
        DoubleLinkedList<T> _list;

        public Queue()
        {
            _list = new DoubleLinkedList<T>();
        }
        public int Count
        {
            get { return _list.Count; }
        }
        public void Enqueue(T item)
        {
            if (_list.AddLast(item) == null)
                throw new QueueException("Enqueue is failed.");
        }
        public T Dequeue()
        {
            if (_list.IsEmpty())
                throw new QueueException("The queue is empty.");
            T tValue = _list.First.Value;
            _list.RemoveFirst();
            return tValue;
        }
        public T Peek()
        {
            if(_list.IsEmpty())
                throw new QueueException("The queue is empty.");
            T tValue = _list.First.Value;
            return tValue;
        }
        public T GetElement(int iIndex)
        {
            return _list[iIndex];
        }
        public bool IsEmpty()
        { return _list.IsEmpty(); }
        public void Clear()
        {
            _list.Clear();
        }
    }
}
