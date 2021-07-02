using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : TileScript
{
    
    [SerializeField] GameObject applePrefab;
    bool hasApple = false;

    public bool HasApple()
    {
        return hasApple;
    }
    public bool SetApple()
    {
        if(hasApple)
        {
            return false;
        }
        else
        {
            applePrefab = Instantiate(applePrefab, transform.position, Quaternion.identity);
            applePrefab.transform.parent = transform;
            hasApple = true;
            return true;
        }
        
    }
    public bool TakeApple()
    {
        if(!hasApple)
        {
            return false;
        }
        else
        {
            hasApple = false;
            Destroy(applePrefab.gameObject);
            applePrefab = null;
            return true;
        }
    }
}
