namespace hop2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("please enter your name ");
        string name=Console.ReadLine();
        try
        {
            control(name);
            Console.WriteLine(name);
            Console.WriteLine("zaten malumunuz hata alırsak burası çalışmaz");
        }
        catch(ShortName e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("mesala hata alsa da almasada bu kısım çalışır");

    }
    public static void control(string name)
    {
        if(name.Length<5)
            throw new ShortName("boyle isim mi olur"); 
        else
            return;
    }
}

public class ShortName : Exception
{
    public ShortName(string message):base(message){}
}