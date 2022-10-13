using System;

namespace DictionaryDs
{
    public partial class KeyValue<TKey, TValue>
    {
        public TKey Key {get; set;}
        public TValue Value { get; set; }
        private int _count;
        private int _capacity;
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} }
        public KeyValue<TKey,TValue>[]  Array { get; set; }

        public TValue this[TKey key] { get{
            TValue output = default(TValue);
            int index=0;
            bool temp = LinearSearch(key,out index);
            if(temp){
                output= Array[index].Value;
            }else{
                Console.WriteLine($"Invalid Key");
            }
            return output;

        } set{
            int position=0;
            bool temp = LinearSearch(key, out position);
            if(temp){
                Array[position].Value=value;
            }
            else{
                Console.WriteLine($"Invaild Key");
            };
            } 
        }

        public KeyValue(){
            _capacity=3;
            _count=0;
            Array = new KeyValue<TKey, TValue>[_capacity];
        }

        public KeyValue(int size){
            if(size == 0){
                _capacity=3;
                _count=0;
                Array = new KeyValue<TKey, TValue>[_capacity];
            }
            else if (size>0){
                _capacity=_capacity*2;
                Array = new KeyValue<TKey,TValue>[_capacity];
            }
            
        }
    }
}