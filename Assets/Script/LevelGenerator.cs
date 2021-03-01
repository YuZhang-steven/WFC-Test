using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public static LevelGenerator instance;
    public int width = 3;
    public int length = 5;
    public int height = 10;
    
    
    
    public GridElement gridElement;
    public GridElement[][][] gridElements;
    // Start is called before the first frame update
    void Start()
    {
        gridElements = new GridElement[width][][];
        instance = this;
        
        for (int x = 0; x < width; x++)
        {
            GridElement[][] gridElements01 = new GridElement[height][];
            for (int y = 0; y < height; y++)
            {
                GridElement[] gridElements02 = new GridElement[length];
                for (int z = 0; z < length; z++)
                {
                    GridElement g = Instantiate(gridElement, new Vector3(x, y, z), Quaternion.identity, this.transform);
                    g.initialize(x, y, z);
                    gridElements02[z] = g;
                }
                gridElements01[y] = gridElements02;
            }
            gridElements[x] = gridElements01;
        }
    }


}
