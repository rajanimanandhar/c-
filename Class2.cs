// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Nilgiri");

public class Workshop1
{

    public static void main()
    {
   
        string[] names = new string[3] {
            "Yuvraj",
            "hari",
            "shyam"
        };
        Console.WriteLine("First index:" + names[0]);
        Console.WriteLine("Second index: " + names[1]);
        Console.WriteLine("Thrid index: " + names[2]);

        var jaggedArray = new int[][]
        {
            new int[] { 1, 2, 3_00_000},
            new int[] { 7,9 },
            new int[] { 4,5,6,9,1 },

        };
        Console.WriteLine(jaggedArray[2][4]);
    }


}
