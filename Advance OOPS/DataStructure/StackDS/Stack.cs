using System;

namespace StackDS
{
    public partial class Stack<Type>
    {
        private int _count;
        private int _capacity;
        private Type[] Array {get; set;}
        public int Count { get{ return _count;}} 

        public Stack(){
            _count = 0;
            _capacity = 4;
            Array = new Type[_capacity];
        }
        
        public Stack(int size){
            _count = 0;
            _capacity = size;
            Array = new Type[_capacity];
        }
        
        public void Push(Type data){
            if(_count == _capacity){
                Growsize();
            }
            Array[_count]=data;
            _count++;
        }
        public void Growsize(){
            _capacity = _capacity * 2;
            Type[] Temp = new Type[_capacity];
            for(int i=0; i<_count; i++){
                Temp[i] = Array[i];
            }
            Array = Temp;
        }

        public Type Pop(){
            Type value = default(Type);
            if(_count < 0){
                Console.WriteLine($"Empty Stack");
            }else if(_count >= 0){
                value = Array[_count];
                _count--;                
            }
            return value;
        }

        public bool Contains(Type data){
            // bool value = false;
            for(int i=0; i<_count; i++){
                if(Array[i].Equals(data)){
                    return true;
                }
            }return false;
        }

        public Type Peek(){
            Type value = default(Type);
            if(_count < 0){
                Console.WriteLine($"Empty Stack");
            }else if(_count >= 0){
                value = Array[_count];               
            }
            return value;
        }



    }
}