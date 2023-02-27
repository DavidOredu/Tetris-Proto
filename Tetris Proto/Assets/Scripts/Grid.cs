using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Grid : MonoBehaviour
{
    [SerializeField]
    private Tile gridPrefab;

    private Spawner spawner;

    public static Tile[,] grid;
    public int length;
    public int width;
    // Start is called before the first frame update
    void Awake()
    {
        spawner = FindObjectOfType<Spawner>();
        grid = new Tile[width, length];
        GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spawner.SpawnBlock(new Vector2Int(width / 2, length));
        }
    }
    private void GenerateGrid()
    {
        Vector2 position = Vector2.zero;

        bool shaded = false;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < length; y++)
            {
                var gridObj = Instantiate(gridPrefab, new Vector3(x, y, 0), Quaternion.identity, transform);

                if (shaded)
                {
                    gridObj.tile.color = new Color(gridObj.tile.color.r, gridObj.tile.color.g, gridObj.tile.color.b, gridObj.tile.color.a + 50f);
                    shaded = false;
                }
                else
                {
                    gridObj.tile.color = new Color(gridObj.tile.color.r, gridObj.tile.color.g, gridObj.tile.color.b, gridObj.tile.color.a);
                    shaded = true;
                }
                grid[x, y] = gridObj;
            }
        }
    }
}
