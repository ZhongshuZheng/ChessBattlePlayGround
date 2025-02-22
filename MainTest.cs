using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MainTest : MonoBehaviour
{

    public Tilemap tilemap;

    // Start is called before the first frame update
    void Start()
    {
        // 获取 Tilemap 的边界
        BoundsInt bounds = tilemap.cellBounds;

        // 获取指定边界内的所有瓦片
        TileBase[] allTiles = tilemap.GetTilesBlock(bounds);
        // Debug.Log($"bounds size: {bounds.size.x}, {bounds.size.y}; len: {allTiles.Length}");
        // Debug.Log($"bounds edge: x:{bounds.xMin}, {bounds.xMax}; y:{bounds.yMin}, {bounds.yMax}");
        // 遍历所有瓦片
        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                int index = x + y * bounds.size.x;

                TileBase tile = allTiles[index];
                // Debug.Log($"index={index} = {x} + {y} * {bounds.size.x}");
                if (tile != null)
                {
                    Vector3Int tilePosition = new Vector3Int(bounds.xMin + x, bounds.yMin + y, 0);
                    Debug.Log($"瓦片位置: {tilePosition}, 瓦片类型: {tile.name}, 实际位置: {tilemap.CellToLocal(tilePosition)}");
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
