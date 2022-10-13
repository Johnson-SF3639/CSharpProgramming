using System;

namespace ArrayListDS
{
    public partial class ArrayList<dynamic>
    {
        //Array List Add Method
        public void Add(dynamic data){
            if(_count == _capacity){
                GrowSize();
            }else{
                Array[_count]=data;
                _count++;
            }
        }
        public void GrowSize(){
            _capacity = _capacity*2;
            dynamic[] temp = new dynamic[_capacity];
            for(int i=0; i < _count; i++){
                temp[i]=Array[i];
            }
            temp=Array;
        }

        //Insert Array Element 
        public void Insert(int index, dynamic data){
            _capacity++;
            dynamic[] temp = new dynamic[_capacity];
            for(int i=0; i<_capacity; i++){
                if(i < index){
                    temp[i]=Array[i];
                }else if(i == index){
                    temp[i]=data;
                }else{
                    temp[i]=Array[i-1];
                }
            }
            Array=temp;
        }

        //Remove element
        public void Remove(dynamic data){
            _capacity--;
            int i;
            dynamic[] temp = new dynamic[_capacity];
            for(i=0; i<_count; i++){
                if(Array[i].Equals(data)){
                    for(int j=i+1; j<_count; j++){
                        temp[i]= Array[j];
                        i++;
                    }
                    break;
                }
                else{
                    temp[i] = Array[i];
                }
            }
            Array = temp;
        }

        //Remove At
        public void RemoveAt(int index){
            _capacity--;
            int i;
            dynamic[] temp = new dynamic[_capacity];
            for(i=0; i<_capacity; i++){
                if(i<index){
                    temp[i] = Array[i];
                }
                else if(i == index){
                    continue;
                }
                else{
                    temp[i-1]= Array[i];
                }
            }
            Array = temp;
        }
    }

        //Contains
        // public bool Contains(dynamic data){
        //     bool value = false;
        //     for(int i=0; i<_count; i++){
        //         if(Array[i].Equals(data)){
        //             value=true;
        //             return value;
        //         }
        //     }return value;
        // }


}