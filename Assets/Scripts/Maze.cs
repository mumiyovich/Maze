using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Maze : MonoBehaviour
{

}

public class RND
{
    //public ulong Seed;
    public byte Seed;
    public int Min=0;
    public int Max=100;

    private ulong _d = 3;//1103515245;

    public RND(uint seed)
    {
        Seed = (byte)seed;
    }

    public void Forward()
    {
        //Seed = Seed * 1103515245 + 12345;

        byte s = Seed;
        for (ulong i =0; i<_d;i++)
        {
            Seed += s;
        }

        Seed = (byte)(Seed+12345);


    }

    public void Back()
    {
        //Seed = (Seed - 12345) / 1103515245;

        Seed = (byte)(Seed - 12345);
        byte s = Seed;
        for (ulong i = 0; i < _d; i++)
        {
            Seed -= s;
        }

    }

    public int Get()
    {
        return (int)((uint)(Seed / 65536) % (Max-Min+1) + Min);
    }

    public int GetForward()
    {
        Forward();
        return Get();
    }

    public int GetBack()
    {
        Back();
        return Get();
    }

}
