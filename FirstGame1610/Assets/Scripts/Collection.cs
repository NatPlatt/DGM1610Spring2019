using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<Object> ColllectionList01;
    
//    public List<FloatData> CollectionList02;
    
//    public void Collect(FloatData obj)
//    {
//        CollectionList02.Add(obj);
//    }

    public void Collect(Object obj)
    {
        ColllectionList01.Add(obj);
    }
    
//    public void CollectionInfo()//in class
//    {
//        foreach (var obj in CollectionList02)
//        {
//            Debug.Log(obj);
//        }
//    }
//
//    public void AmmoInfo()//in class
//    {
//        foreach (var obj in CollectionList02)
//        {
//            if (obj.name == "Ammo")
//            {
//                Debug.Log("We have " + obj.Value + " ammo.");
//            }
//        }
//        
//    }
//
//    public void FeulInfo()
//    {
//        for (int i = 0; i < CollectionList02.Count; i++)
//        {
//            if (CollectionList02[i].name == "Feul")
//            {
//                Debug.Log(CollectionList02[i]);
//            }
//        }
//    }
}
