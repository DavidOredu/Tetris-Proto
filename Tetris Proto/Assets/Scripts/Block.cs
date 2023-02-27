using Sirenix.OdinInspector;
using UnityEngine;
using Sirenix.Utilities;

public class Block : SerializedMonoBehaviour
{
    [TableMatrix(HorizontalTitle = "Block Shape", SquareCells = true, ResizableColumns = true)]
    public Tile[,] shape;

    public BlockData blockData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    [OnInspectorInit]
    private void CreateData()
    {
        shape = new Tile[3, 3];
    }

}
