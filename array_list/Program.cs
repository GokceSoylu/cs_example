using System.Collections;
//! cmd k c toplu yorum satırına dönüştürür
namespace array_list;
class Program
{
    static void Main(string[] args)
    {
        ArrayList arr =new ArrayList(); 
        arr.Add("hasan sabbah");
        arr.Add("lale");
        arr.Add("soylu");
        arr.Add(2022);
        arr.Add(2023);
        arr.Add(1111);
        Console.WriteLine(arr.IndexOf("hasan sabbah"));

        int index=arr.IndexOf("hasan sabbah");

        Console.WriteLine(arr.Count);
        Console.WriteLine(arr.Capacity);
      
    
        for(int i=0;i<3;i++ )
            arr.RemoveAt(3);

        foreach(var e in arr)
            Console.WriteLine(e);
        arr.Sort();
        arr.RemoveAt(0);
        arr.Reverse();
        arr.RemoveAt(0);

        Console.WriteLine("arr[0] = "+arr[0]);

        ArrayList  arr2=new ArrayList();
        arr2.Add("derya");
        arr2.Add("kemal");
        arr2.Add("saçmalık");


        ArrayList arr3=new ArrayList();
        arr3.Add("kuzu");
        arr3.Add("mustafa");

        arr.AddRange(arr2);
        arr.InsertRange((arr.IndexOf("derya")),arr3);
        Console.WriteLine(arr.Capacity);
        arr.Insert(arr.IndexOf("saçmalık"),"dünya");//! e
        if(arr.Contains("dünya"))
        {
            foreach(var e in arr)
            {
                Console.WriteLine(e);
            }
        }


    }
}