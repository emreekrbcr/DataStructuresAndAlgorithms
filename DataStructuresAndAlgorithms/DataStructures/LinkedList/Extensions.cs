namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    static class Extensions //sıralama metodlarını metodun içinde sürekli if else ile typeof(T)==typeof(int) gibi bir kullanım yapmaktansa sadece o tipe özel ilgili metodu olarak kullanmak için 
    {
        public static void SortList(this AbstractLinkedList<int> thisList)
        {
            int[] tempArray;
            tempArray = thisList.CopyToArray(thisList.Length);
            tempArray = tempArray.SortArray();

            for (int i = 0; i < thisList.Length; i++)
            {
                thisList[i] = tempArray[i];
            }
        }

        public static void SortList(this AbstractLinkedList<string> thisList)
        {
            string[] tempArray;
            tempArray = thisList.CopyToArray(thisList.Length);
            tempArray = tempArray.SortArray();

            for (int i = 0; i < thisList.Length; i++)
            {
                thisList[i] = tempArray[i];
            }
        }

        public static void AddInSorted(this AbstractLinkedList<int> thisList, int data)
        {
            ListNode<int> newNode = new ListNode<int>(data);
            ListNode<int> iter = thisList.HeadNode;

            while (iter.Next != null && iter.Next.Data < data)
            {
                iter = iter.Next;
            }

            newNode.Next = iter.Next;
            iter.Next = newNode;
        }

        public static void AddInSorted(this AbstractLinkedList<string> thisList, string data)
        {
            ListNode<string> newNode = new ListNode<string>(data);
            ListNode<string> iter = thisList.HeadNode;
            while (iter.Next != null && iter.Next.Data.IsLower(data))
            {
                iter = iter.Next;
            }

            newNode.Next = iter.Next;
            iter.Next = newNode;
        }
    }
}
