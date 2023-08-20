using System;
using System.Linq;

//ref link:https://www.youtube.com/watch?v=7ssbfLdQGyg&list=PLRwVmtr-pp06SlwcsqhreZ2byuozdnPlg&index=8
// ..

class MainClass
{
    static void Main()
    {
        int[] ints = new[] { 1, 9, 2, 7, 4, 3, 6, 5, };
        IEnumerable<int> result =
            //ints.Where(i => i < 5);
            Enumerable.Where(ints, i => i < 5);
        //Queryable.Where()????
        IEnumerable<int> result2 =
            Queryable.Where(ints, i => i < 5);


        foreach (int i in result)
            Console.WriteLine(i);

    }
}