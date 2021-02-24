namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class SinglyLinkedList<T> : AbstractLinkedList<T>
    {
        public ListNode<T> First
        {
            get
            {
                return HeadNode.Next;
            }
        }

        public ListNode<T> Last
        {
            get
            {
                ListNode<T> iter = HeadNode;

                if (HeadNode.Next != null)
                {
                    while (iter.Next != null)
                    {
                        iter = iter.Next;
                    }

                    return iter;
                }

                return null;
            }
        }

        public SinglyLinkedList() //ctor
        {
            HeadNode.Next = null;
        }

        public override int Length //override base Length prop
        {
            get
            {
                ListNode<T> iter = HeadNode;

                int i = 0;

                while (iter.Next != null)
                {
                    iter = iter.Next;
                    i++;
                }

                return i;
            }
        }

        public override string ToString()
        {
            string listString = "";
            string interValueExpression = " >> ";

            ListNode<T> iter = HeadNode;

            while (iter.Next != null)
            {
                iter = iter.Next;
                listString = listString + iter.Data + interValueExpression;
            }

            if (listString.Length > interValueExpression.Length)
            {
                listString = listString.Substring(0, listString.Length - interValueExpression.Length); //sondaki >> fazlalığını çıkarmak için
            }

            return listString;
        }

        public override void AddFirst(T data)
        {
            ListNode<T> newNode = new ListNode<T>(data);
            newNode.Next = HeadNode.Next;
            HeadNode.Next = newNode;
        }

        public override void AddLast(T data)
        {
            ListNode<T> newNode = new ListNode<T>(data);

            ListNode<T> iter = HeadNode;

            while (iter.Next != null)
            {
                iter = iter.Next;
            }

            newNode.Next = null;
            iter.Next = newNode;
        }

        public override bool Search(T searchedData) //dışarı servis ederken out'a gerek yok
        {
            return Search(searchedData, out ListNode<T> temp);
        }

        protected override bool Search(T searchedData, out ListNode<T> prevOfSearchedNode) //out'daki ifade Search metodunu Delete'de kullanabilmek için
        {
            ListNode<T> iter = HeadNode;

            if (typeof(T) == typeof(string)) //sadece ve sadece string'e özel bir durum olduğu için
            {
                while (iter.Next != null)
                {
                    iter = iter.Next;

                    if (searchedData.ToString().ToLower() == iter.Data.ToString().ToLower()) //o zaman veri listede bulunmuş demektir. ToLower'lar data'ların case insensitive olması için
                    {
                        prevOfSearchedNode = iter;
                        return true;
                    }
                }
            }
            else
            {
                while (iter.Next != null)
                {
                    iter = iter.Next;

                    if (searchedData.Equals(iter.Data))
                    {
                        prevOfSearchedNode = iter;
                        return true;
                    }
                }
            }

            prevOfSearchedNode = null;
            return false;
        }

        public override bool Delete(T dataToBeDeleted)
        {
            bool wasFound = Search(dataToBeDeleted, out ListNode<T> prevOfToBeDeletedNode);

            if (wasFound)
            {
                prevOfToBeDeletedNode.Next = prevOfToBeDeletedNode.Next.Next;
            }

            return wasFound;
        }
    }
}