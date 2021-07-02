using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TileScript : MonoBehaviour
{
    protected Vector2Int gridPos;
    public Vector2Int GridPos { get { return gridPos; } }
}
