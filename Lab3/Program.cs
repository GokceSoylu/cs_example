using System.Collections;
using System.IO;
namespace Lab3;
class Program
{
    static void Main(string[] soylu)
    {
        Staff s1=new Staff("necmiye","Ceng",10);
        Staff s2=new Staff("hasan","worn",100);
        Staff s3=new Staff("kemmal","Rebublic-ing",1000);
        Staff s4=new Staff("sabriye","Ceng",20);
        Staff s5=new Staff("ilkay","Ceng",30);

        ArrayList arr_staff=new ArrayList();
        arr_staff.Add(s1);
        arr_staff.Add(s2);
        arr_staff.Add(s3);
        arr_staff.Add(s4);
        arr_staff.Add(s5);
        int result=SumSalary(arr_staff);
        Console.WriteLine(result);

    }
    static int SumSalary(ArrayList arr)
    {
        int sum=0;
        foreach(Staff e in arr)
            sum+=(Staff)e.salary;
        return sum;
    }
}
public class Staff
{
    string name;
    string department;
    int salary;
    public Staff(string name, string department, int salary){
        this.salary=salary;
        this.department=department;
        this.name=name;
    }
    
}