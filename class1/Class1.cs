namespace CustomExtensionLib;

public static class Class1
{

    public static int WorCount(this string str)
    {

        return str.Split(new char[]{' ','.','?'}, StringSplitOptions.RemoveEmptyEntries).Length;

    }

}
