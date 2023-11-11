using System.Collections;

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
        Console.WriteLine("cıkarmada once stır 21");
        try{
            for(int i=3;i<6;i++ )
                arr.Remove(index+i);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);

        }
        Console.WriteLine("cıkarm aişlemi bitti");
        try{
            foreach(var e in arr)
            {
                Console.WriteLine(e);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine(" yazdırma bitti");
        try
        {
            arr.Sort();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        arr.RemoveAt(0);
        arr.Reverse();
        arr.RemoveAt(0);

        Console.WriteLine("arr[0] = "+arr[0]);

        ArrayList  arr2=new ArrayList();
        arr2.Add("derya");
        arr2.Add("kemal");
        arr2.Add("saçamalık");

        ArrayList arr3=new ArrayList();
        arr3.Add("kuzu");
        arr3.Add("mustafa");

        arr.AddRange(arr2);
        arr.InsertRange((arr.IndexOf("derya"))+1,arr3);

        arr.Insert((arr.IndexOf("saçmalık")),"dünya");
        if(arr.Contains("sacmalık"))
        {
            foreach(var e in arr)
            {
                Console.WriteLine(e);
            }
        }


    }
}