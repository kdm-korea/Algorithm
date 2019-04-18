
namespace Tree
{
    interface ITree<T, E>
    {
        bool Insert(E node, T data, Direct direct);
        bool Delete(T data);
        Node<T> Retreive(T data);
        Node<T> Root();
    }
}
