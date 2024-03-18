using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class Surgery : MonoBehaviour
{

    public Tilemap Skin;
    public Tilemap FrontRibs;
    public Tilemap Lungs;
    public Tilemap Heart;
    public Tilemap BackRibs;

    public GameObject BloodEffect;

    private List<Vector3Int> cellsToRemove = new List<Vector3Int>();

    private Vector3Int lastcell;

    public Tile defTile;

    float heartValue = 100f;
    void Start()
    {
        
    }


    private void Update()
    {
        Vector3 MP = Camera.main.ScreenToWorldPoint(new Vector3((Input.mousePosition.x), (Input.mousePosition.y), 0));
        Vector3Int cell = new Vector3Int(Mathf.FloorToInt(MP.x), Mathf.FloorToInt(MP.y), 0);
        if (Input.GetMouseButtonDown(0)||(Input.GetMouseButton(0) && lastcell != cell)) 
        {
            lastcell = cell;
            selectTile(cell);
        }
    }

    void selectTile(Vector3Int cell)
    {


        cellsToRemove.Clear();

        if (Skin.HasTile(cell))
        {
            if (collectionCheck(Skin, cell))
            {
                foreach(Vector3Int pos in cellsToRemove)
                {
                    Skin.SetTile(pos, null);
                }
                
            }
            else
            {
                Skin.SetTile(cell, null);
                Instantiate(BloodEffect, cell, Quaternion.identity);
            }
        }
        else if (FrontRibs.HasTile(cell))
        {
            if (collectionCheck(FrontRibs, cell))
            {
                foreach (Vector3Int pos in cellsToRemove)
                {
                    FrontRibs.SetTile(pos, null);
                }

            }
            else
            {
                FrontRibs.SetTile(cell, null);
            }
        }
        else if (Lungs.HasTile(cell))
        {
            if (collectionCheck(Lungs, cell))
            {
                foreach (Vector3Int pos in cellsToRemove)
                {
                    Lungs.SetTile(pos, null);
                }

            }
            else
            {
                Lungs.SetTile(cell, null);
                Instantiate(BloodEffect, cell, Quaternion.identity);
                Instantiate(BloodEffect, cell, Quaternion.identity);
            }
        }
        else if (Heart.HasTile(cell))
        {
            if (collectionCheck(Heart, cell))
            {
                int successfulCollection=0;
                foreach (Vector3Int pos in cellsToRemove)
                {
                    Heart.SetTile(pos, null);
                    successfulCollection++;
                }
                successfulCollection = Mathf.Clamp(successfulCollection, 0, 46);
                //46 total tiles in heart
                Debug.Log("£"+((float)successfulCollection / 46f) * heartValue);
                FindFirstObjectByType<Manager>().money+= ((float)successfulCollection / 46f) * heartValue;
                FindFirstObjectByType<Manager>().UnLoadSurgery();
                FindFirstObjectByType<Manager>().kills++;
                num.diff = num.diff + 1;
                num.lore = num.lore + 1;
            }
            else
            {
                Heart.SetTile(cell, null);
                Instantiate(BloodEffect, cell, Quaternion.identity);
                Instantiate(BloodEffect, cell, Quaternion.identity);
                Instantiate(BloodEffect, cell, Quaternion.identity);
            }
        }

    }

    bool collectionCheck(Tilemap tm, Vector3Int cell)
    {
        if(Mathf.Abs(tm.CellToWorld(cell).x) >= 10 || Mathf.Abs(tm.CellToWorld(cell).y) >= 10)
        {
            return false;
        }
        else
        {
            cellsToRemove.Add(cell);
            if (tm.HasTile(cell + new Vector3Int(0, 1, 0)) && !cellsToRemove.Contains(cell + new Vector3Int(0, 1, 0))) 
            {
                if(!collectionCheck(tm, cell + new Vector3Int(0, 1, 0)))
                {
                    return false;
                }
            }
            if (tm.HasTile(cell + new Vector3Int(0, -1, 0)) && !cellsToRemove.Contains(cell + new Vector3Int(0, -1, 0)))
            {
                if(!collectionCheck(tm, cell + new Vector3Int(0, -1, 0)))
                {
                    return false;
                }
            }
            if (tm.HasTile(cell + new Vector3Int(1, 0,0)) && !cellsToRemove.Contains(cell + new Vector3Int(1, 0,0)))
            {
                if(!collectionCheck(tm, cell + new Vector3Int(1,0, 0)))
                {
                    return false;
                }
            }
            if (tm.HasTile(cell + new Vector3Int(-1, 0, 0)) && !cellsToRemove.Contains(cell + new Vector3Int(-1, 0, 0)))
            {
                if(!collectionCheck(tm, cell + new Vector3Int(-1, 0, 0)))
                {
                    return false;
                }
            }
        }




        return true;
    }
}
