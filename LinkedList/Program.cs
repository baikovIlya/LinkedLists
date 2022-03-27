using Lists;


LinkedList lis = new LinkedList(new int[] {4,4,4,0,4,4,4});
LinkedList lis2 = new LinkedList(new int[] {4,4,4,0,4,4,4});
bool a = false;
a = lis.Equals(lis2);
Console.WriteLine(a);