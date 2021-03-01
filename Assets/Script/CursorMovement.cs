using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    RaycastHit hit;
    Ray ray;
    GridElement lastHit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit) && hit.collider.tag =="GridElement")
        {
            this.transform.position = hit.collider.transform.position;
            lastHit = hit.collider.gameObject.GetComponent<GridElement>();

            if(Input.GetMouseButtonDown(1))
            {
                setCurserButton(0);
            }
        }
    }

    public void setCurserButton(int input)
    {
        Coordinator coord = lastHit.GetCoordinator();
        int width = LevelGenerator.instance.width;
        int length = LevelGenerator.instance.length;
        int height = LevelGenerator.instance.height;

        switch (input)
        {
            case 0:
                //remove GridElement;
                if(coord.y > 0)
                {
                    lastHit.setDisble();
                }
                
                
                
                break;
            case 1:
                //add x+
                if (coord.x < width - 1)
                {
                    LevelGenerator.instance.gridElements[coord.x + 1][coord.y][coord.z].setEnable();
                }
                
                
                
                break;
            case 2:
                //add x-
                if (coord.x > 0)
                {
                    LevelGenerator.instance.gridElements[coord.x - 1][coord.y][coord.z].setEnable();
                }
                
                Debug.Log("6");

                break;
            case 3:
                if (coord.z < length - 1)
                {
                    LevelGenerator.instance.gridElements[coord.x][coord.y][coord.z + 1].setEnable();
                }
                //add z+
                
                break;
            case 4:
                if (coord.z > 0)
                {
                    LevelGenerator.instance.gridElements[coord.x][coord.y][coord.z - 1].setEnable();
                }
                //add z-
                
                break;
            case 5:
                if (coord.y < height - 1)
                {
                    LevelGenerator.instance.gridElements[coord.x][coord.y + 1][coord.z].setEnable();
                }
                //add y+
                
                break;



        }
    }
}
