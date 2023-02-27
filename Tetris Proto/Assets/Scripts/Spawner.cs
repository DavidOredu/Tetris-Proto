using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] blockPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBlock(Vector2Int spawnPosition)
    {
        int random = Random.Range(0, blockPrefabs.Length);
        var newBlock = Instantiate(blockPrefabs[random], new Vector3(spawnPosition.x, spawnPosition.y), Quaternion.identity);
        var blockScript = newBlock.GetComponent<Block>();
        Grid.grid[spawnPosition.x, spawnPosition.y].tileSprite.color = blockScript.blockData.color;
    }
}
