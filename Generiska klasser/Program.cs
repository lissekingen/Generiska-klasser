public class Ko<T> where T:IComparable{
 
  
  int len;
  T[] items;
  int last;
  
T temp;
  public int Compare(Ko<T> Ko3){
for (int i = 0; i < len; i++)
{
  if(items[i].CompareTo(Ko3.items[i])!=0){
    return -1;
  }
 
}
return 0;
  }
 
 public void Add(T e){
if(last<len-1){
  items [last+1]=e;
  last++;
}
}
  public void Swap(int firstindex, int secondindex){
temp = items[firstindex];
items[firstindex] = items[secondindex];
items[secondindex] = temp;
  }
  public Ko(int listlen){
len = listlen;
last = -1;
items = new T[len];
}
  public void Remove(int removeindex){
for (int i = removeindex; i <= last; i++)
{
  items[removeindex] = items[removeindex+1];
}
last--;
  }
 
  public bool IsEmpty(){
Console.WriteLine(last<0);
return last<0;
  }
  public void print(){
Console.WriteLine(items);
  }
 
}
class Program{
public static void Main(){
 
}
}