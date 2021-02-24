namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class ListNode<T> //Listedeki node yapısı
    {
        public T Data { get; set; } //Datanın olduğu yer

        public ListNode<T> Next { get; set; } //Link yani bir sonraki düğümü gösteren yapı
        public ListNode<T> Prev { get; set; } //DoublyList için bir önceki düğümü gösteren yapı

        public ListNode(T data)
        {
            this.Data = data;
        }

        public ListNode()
        {

        }
    }
}
