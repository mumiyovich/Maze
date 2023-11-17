
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        /*
        byte b = 255;
        byte a = 255;
        byte c = 255;

        c += a;
        Debug.Log(c);
        c += a;
        Debug.Log(c);
        c += a;
        Debug.Log(c);

        c -= a;
        Debug.Log(c);
        c -= a;
        Debug.Log(c);
        c -= a;
        Debug.Log(c);
        */



        
        RND rnd = new RND(0);

        int c = 3;
        
        for (int i = 0; i < c; i++)
        {
            Debug.Log(rnd.GetForward().ToString()+"      "+rnd.Seed);
        }
        Debug.Log("----------------");
        for (int i = 0; i < c; i++)
        {
            Debug.Log(rnd.GetBack().ToString() + "      " + rnd.Seed);
        }
        


        /*
        Debug.Log(rnd.Seed);
        rnd.Forward();
        Debug.Log(rnd.Seed);
        rnd.Forward();
        Debug.Log(rnd.Seed);
        rnd.Back();
        Debug.Log(rnd.Seed);
        rnd.Back();
        Debug.Log(rnd.Seed);
        */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
