using System;

namespace DataStructure.LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> _head;
        public Node<T> _current;
        public int _count;

        public LinkedList(){
            _head = null;
            _current = _head;
        }

        public Node<T> First { get {return _head; } }
        public Node<T> Last { get {return _current; } }

        public void AddFirst(T value)
        {
            if(_current == null){
                CreateInitialNode(value);
            }
            else{
                var newNode = new Node<T>{ Value = value };
                newNode.Next = _head;                
                _head = newNode;                                
            }      
            _count++;          
        }
        public void AddLast(T value)
        {
            if(_current == null){
                CreateInitialNode(value);
            }
            else{
                var newNode = new Node<T>{ Value = value };
                _current.Next = newNode;                
                _current = newNode;                                
            }      
            _count++;          
        }

         public void AddAfter(Node<T> node, T value)
        {
            if(node == null){
                throw new ArgumentNullException(nameof(node));
            }
            else{
                var newNode = new Node<T>{ Value = value };
                newNode.Next = node.Next;       
                node.Next = newNode;                           
            }      
            _count++;          
        }

         public void AddBefore(Node<T> node, T value)
        {
            if(node == null){
                throw new ArgumentNullException(nameof(node));
            }
            else{
                var newNode = new Node<T>{ Value = value };
                newNode.Next = node.Next;       
                node.Next = newNode;                           
            }      
            _count++;          
        }

        public void DeleteFirst(){
            if(_head != null)
            {
                _head = _head.Next;
                _count--;
            }
        }
        public void DeleteLast(){
            if(_current != null)
            {
                if(_count == 1){
                    _head = _current = null;
                    _count = 0;
                }
                Node<T> curr = _head;
               while(curr.Next.Next != null)
               {
                    curr = curr.Next;
               }
               curr.Next = null;
               _count--;
            }
        }     

        public void Delete(int index){
            if(_current != null)
            {
                if(_count == 1){
                    _head = _current = null;
                    _count = 0;
                }
                Node<T> curr = _head;
               while(curr.Next.Next != null)
               {
                    curr = curr.Next;
               }
               curr.Next = null;
               _count--;
            }
        }        

        private void CreateInitialNode(T value){
              _head = new Node<T>{ Value = value };
               _current = _head;
        }
    }
}