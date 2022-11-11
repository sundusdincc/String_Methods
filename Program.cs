internal class Program
{
    private static void Main(string[] args)
    {
        string x="String Metotlar ";
        string y="Hazır Metotlar";
        string z="string Metotlar ";
        string t="Metotlar";

        //length
        Console.WriteLine(x.Length);
        Console.WriteLine(y.Length);

        //ToUpper-ToLower
        Console.WriteLine(x.ToUpper());
        Console.WriteLine(x.ToLower());

        //Concat
        Console.WriteLine(string.Concat(x,y)); 

        //Compare-CompareTo
        Console.WriteLine(x.CompareTo(y)); //0,1,-1 
        Console.WriteLine(String.Compare(x,z,false)); //0,1,-1 bool ignoreCase:true(büyük küçük harf duyarlı)...
        Console.WriteLine(String.Compare(x,z,true));

        //Contains
        Console.WriteLine(x.Contains(t));
        Console.WriteLine(x.EndsWith("Metotlar "));
        Console.WriteLine(x.StartsWith("String"));

        //IndexOf
        Console.WriteLine(x.IndexOf("Me"));
        Console.WriteLine(x.IndexOf("Test"));
        Console.WriteLine(x.LastIndexOf("a"));


        //insert
        Console.WriteLine(x.Insert(16,"C# "));

        //PadLeft-PadRight
        Console.WriteLine(x + t.PadLeft(20));
        //Console.WriteLine(x + y.PadLeft(20,"*"));
        Console.WriteLine(x.PadRight(50) + t);
        //Console.WriteLine(x.PadRight(50,"+") + t);

        //Remove
        Console.WriteLine(x.Remove(10));//10. indexden başlayarak sonuna kadar siler
        Console.WriteLine(x.Remove(0,3));//0. indexten başlayarak 3 karakter sil
        
        //Replace
        Console.WriteLine(x.Replace("Metotlar","Method"));//değiştir
        Console.WriteLine(x.Replace(" ","*"));

        //Split
        Console.WriteLine(x.Split(" ")[1]);//boşluklara göre böl ,diziye at ve 1.indexi getir.

        //Substring
        Console.WriteLine(x.Substring(10));//10.indexten başlayarak sonuna kadar getir
        Console.WriteLine(x.Substring(0,3));//0.indexten başlar 3 karakter getirir



    }
}