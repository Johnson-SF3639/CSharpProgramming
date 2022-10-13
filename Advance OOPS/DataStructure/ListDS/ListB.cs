using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListDS 
{
    public partial class Lists <Type>
    {
        public void Remove(Type data){
            _capacity--;
            int i;
            Type[] temp = new Type[_capacity];
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
        
        public void RemoveExtr(Type data){
            _capacity--;
            int i;
            Array= new Type[_capacity];
            for(i=0; i<_count; i++){
                if(Array[i].Equals(data)){
                    for(int j=i+1; j<_count; j++){
                        Array[i]= Array[j];
                        i++;
                    }
                    break;
                }
            }
        }
        public void RemoveAt(int index){
            _capacity--;
            int i;
            Type[] temp = new Type[_capacity];
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
}