using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;

        public Stuff(int bul)
        {
            bullets = bul;
        }

        public Stuff()
        {
            bullets = 1;
        }
    }
    //creating an instance (an object) of the Stuff class
    public Stuff myStuff = new Stuff(50);
    

    private void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
