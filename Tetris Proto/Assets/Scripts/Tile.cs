using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Tile : MonoBehaviour
{
    public UnityEngine.Tilemaps.Tile tile;
    public SpriteRenderer tileSprite;
    // Start is called before the first frame update
    void Awake()
    {
        tile = new UnityEngine.Tilemaps.Tile();
        tileSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
