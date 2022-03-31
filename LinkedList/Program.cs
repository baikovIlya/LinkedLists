using Lists;


LinkedList lis = new LinkedList(new int[] {1,2,3,4,5,6,7});
LinkedList lis2 = new LinkedList(new int[] {4,4,4});
//bool a = false;
//a = lis.Equals(lis2);
////Console.WriteLine(a);
//int s = lis2.Length;
////Console.WriteLine(s);
//lis.DeleteElementsByIndex(2, 1);
//for (int i = 0; i < lis.Length; i++)
//{
//    Console.WriteLine(lis[i]);
//}
//int ind = lis2.SearchIndexByValue(0);
//Console.WriteLine(ind);
lis.AddListAtBegin(lis2);
for (int i = 0; i < lis.Length; i++)
{
    Console.WriteLine(lis[i]);

}