﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{
    
    public List<FloatData> CollectionList;
    
    public void Collect(FloatData obj)
    {
        CollectionList.Add(obj);
    }
    
    public void CollectionInfo()
    {
        foreach (var obj in CollectionList)
        {
            Debug.Log(obj);
        }
    }

    public void AmmoInfo()
    {
        foreach (var obj in CollectionList)
        {
            if (obj.name == "Ammo")
            {
                Debug.Log("We have " + obj.Value + " ammo.");
            }
        }
        
    }

    public void FeulInfo()
    {
        for (int i = 0; i < CollectionList.Count; i++)
        {
            if (CollectionList[i].name == "Feul")
            {
                Debug.Log(CollectionList[i]);
            }
        }
    }
}
