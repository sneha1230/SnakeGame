using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField] SnakeTile snakeTilePrefab;
    private List<SnakeTile> snakePieces;
    public List<SnakeTile> SnakePieces { get { return snakePieces; } }

    public void IntializeSnake()
    {
        snakePieces = new List<SnakeTile>();
        transform.position = GridManager.Instance.GetRandomTile(5).transform.position;
        SnakeTile snakeTile = Instantiate(snakeTilePrefab, transform.position, Quaternion.identity);
        snakeTile.transform.parent = transform;
        SnakePieces.Add(snakeTile);
    }
    void AddPiece()
    {
        SnakeTile snakeTile = Instantiate(snakeTilePrefab, transform.position, Quaternion.identity);
        snakeTile.MoveToTile(snakePieces[snakePieces.Count - 1]);
        snakeTile.MoveLeft();
        snakePieces.Add(snakeTile);
    }

}