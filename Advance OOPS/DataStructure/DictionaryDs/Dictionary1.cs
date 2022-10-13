using System;

namespace DictionaryDs
{
    public partial class KeyValue<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            if (_capacity == _count)
            {
                Expand();
            }
            bool temp = LinearSearch(key, out int index);
            if (temp == true)
            {
                Console.WriteLine($"Duplicate Key");
            }else
            {
                KeyValue<TKey, TValue> entry = new KeyValue<TKey, TValue>();
                entry.Key = key;
                entry.Value = value;
                Array[_count] = entry;
                _count++;
            }

        }
        public void Expand()
        {
            _capacity = _capacity * 2;
            KeyValue<TKey, TValue>[] temp = new KeyValue<TKey, TValue>[_capacity];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = Array[i];
            }
            Array = temp;
        }

        public bool ContainsKey(TKey key){
            bool value = LinearSearch(key, out int index);
            return value;
        }
        
        public bool ContainsValue(TValue value){
            for(int i = 0; i<Count; i++){
                if(Array[i].Equals(value)){
                    return true;
                }
            }
            return false;
        }

        public KeyValue<TKey,TValue> ElementAt(int index){
            KeyValue<TKey, TValue> output = null;
            if(index >= 0 && index < Count ){
                output = Array[index];
            }
            return output;
        }

        public void Remove(TKey key){
            bool temp = LinearSearch(key, out int index);
            KeyValue<TKey, TValue>[] entry = new KeyValue<TKey, TValue>[Count];
            if (temp)
            {
                for(int i=0; i<Count; i++){
                    if(Array[i].Equals(key)){
                        entry[i]=Array[i+1];
                    }
                }
                Array=entry;
                _count--;
            }else
            {
                Console.WriteLine($"Duplicate Key");
            } 
        }


        public void Display()
        {
            foreach (KeyValue<TKey, TValue> element in Array)
            {
                if (element != null)
                {
                    Console.WriteLine($"Key : {element.Key}\t Value : {element.Value}");
                }
            }
        }

        public bool LinearSearch(TKey key, out int index)
        {
            index=0;
            for(int i=0; i <_count; i++)
            {
                if (Array[i].Key.Equals(key))
                {
                    index=i;
                    return true;
                }
            }
            return false;
        }

    }
}