using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordinator
{
    public int x, y, z;

    public Coordinator(int setX, int setY, int setZ)
    {
        x = setX;
        y = setY;
        z = setZ;
    }
}

public class GridElement : MonoBehaviour
{
    private Coordinator coord;
    private Collider col;
    private Renderer rend;

    public void initialize(int setX, int setY, int setZ)
    {
        coord = new Coordinator(setX, setY, setZ);
        this.name = "GE_" + this.coord.x + "_" + this.coord.y + "_" + this.coord.z;
        this.col = this.GetComponent<Collider>();
        this.rend = this.GetComponent<Renderer>();
    }

    public Coordinator GetCoordinator()
    {
        return coord;
    }

    public void setEnable()
    {
        this.col.enabled = true;
        this.rend.enabled = true;
    }

    public void setDisble()
    {
        this.col.enabled = false;
        this.rend.enabled = false;
    }
}
