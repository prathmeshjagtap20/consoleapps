namespace CustomLibrary;

public static class Class1
{

    
// This is extension method
// the first parameter takes the this modifier 
//the specify the type for which the method is define.

    public static int WordCount(this string str)
    {
        return str.Split(new char[]{' ','.','?'},StringSplitOptions.RemoveEmptyEntries).Length;
    }



    public static string UpperCase(this string str)
    {

        string[] s=str.Split(" ");

        for(int i=0;i<s.Length;i++)
        {
            s[i]=s[i].Substring(0,1).ToUpper()+s[i].Substring(1);
        }
        
        str=string.Join(" ",s);
        return str;
    }



}
