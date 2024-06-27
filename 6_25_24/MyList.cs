using System.Collections;

namespace _6_25_24;

internal class MyList:IEnumerable<int>
{
    public int[] arry =  {};
    public int this[int index]
    {
        get { return arry[index]; }
        set
        {
            arry[index] = value;
        }
    }
    public void Add(int n)
    {
        Array.Resize(ref arry, arry.Length+1);
        arry[arry.Length-1] = n;
    }
    public bool Contains(int n)
    {
        foreach (int i in arry)
        {
            if (i == n) return true;
        }
        return false;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for(int i = 0; i < arry.Length; i++)
        {
            yield return arry[i];
        }
    }

    public int IndexOf(int n)
    {
        for (int i = 0; i < arry.Length; i++)
        {
            if (arry[i]==n)
                return i;
        }
        return -1;
    }
    public void Remove(int n)
    {
        for(int i = 0;i < arry.Length; i++)
        {
            if (arry[i] == n)
            {
                for(int j = i;j < arry.Length-1; j++)
                {
                    arry[j] = arry[j+1];
                }
            }
                break;
        }
        Array.Resize(ref arry, arry.Length - 1);
    }
    public void Reverse()
    {
        int temp = 0;
        for(int i = 0;i<( arry.Length/2); i++)
        {
            arry[i] = temp;
            arry[i]= arry[arry.Length-1-i];
            arry[arry.Length - 1-i]= temp;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
