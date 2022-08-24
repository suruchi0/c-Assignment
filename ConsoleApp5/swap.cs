using System;

class RefSwap
{
    int a, b;

    public RefSwap(int i, int j)
    {
        a = i;
        b = j;
    }

    public void show()
    {
        Console.WriteLine("a: {0}, b: {1}", a, b);
    }

    // This method now changes its arguments. 
    public void swap(ref RefSwap ob1, ref RefSwap ob2)
    {
        RefSwap t;

        t = ob1;
        ob1 = ob2;
        ob2 = t;
    }
}