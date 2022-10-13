using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDS
{
    public  partial class Queue<Type>
    {
        private int _count;        
        private int _head;          
        private int _tail;    
        private int _capacity;   
        public int Count { get{return _count;} } 
        private Type[] Array { get; set; }

        public Queue(){
            _count = 0;
            _head = 0;
            _capacity = 4;
            _tail = 0;
            Array = new Type[_capacity];
        }
        public Queue(int size){
            _count = 0;
            _head = 0;
            _capacity = size;
            _tail = 0;
            Array = new Type[_capacity];
        }

        public void EnQueue(Type data){
            if(_tail == _capacity){
                Growsize();
            }
            Array[_tail]=data;
            _tail++;
            _count++;
        }
        public void Growsize(){
            _capacity = _capacity * 2;
            Type[] Temp = new Type[_capacity];
            for(int i=0; i<_tail; i++){
                Temp[i] = Array[i];
            }
            Array = Temp;
        }

        public Type Dequeue(){
            Type value = default(Type);
            if(_head > _tail){
                Console.WriteLine($"Empty queue");
            }else{
                value = Array[_head];
                _head++; 
                _count--;               
            }
            return value;
        }
        
        public Type Peek(){
            Type value = default(Type);
            if(_head > _tail){
                Console.WriteLine($"Empty queue");
            }else{
                value = Array[_head];              
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

    }
}