using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public abstract class AbstractLinkedList<T>:IEnumerable<T>
    {
        public ListNode<T> HeadNode { get; } //root node

        protected AbstractLinkedList()
        {
            HeadNode = new ListNode<T>();
        }

        public abstract int Length { get; }

        public T this[int i] //indexer
        {
            get
            {
                if (i < 0 || i > Length - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                ListNode<T> iter = HeadNode;

                for (int j = 0; j <= i; j++)
                {
                    iter = iter.Next;
                }

                return iter.Data;
            }
            set
            {
                if (i < 0 || i > Length - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                ListNode<T> iter = HeadNode;

                for (int j = 0; j <= i; j++)
                {
                    iter = iter.Next;
                }

                iter.Data = value;
            }
        }

        public IEnumerator GetEnumerator() //foreach ile kullanılabilmesi için
        {
            for (int i = 0; i < Length; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return this[i];
            }
        }

        public new abstract string ToString();
        public abstract void AddFirst(T data);
        public abstract void AddLast(T data);
        public abstract bool Search(T searchedData);
        protected abstract bool Search(T searchedData, out ListNode<T> prevOfSearchedNode); //search'ü delete'de kullanabilmek için D-R-Y
        public abstract bool Delete(T dataToBeDeleted);
    }
}
