using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawn : MonoBehaviour
{

    public GameObject Building;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Building, Input.mousePosition, Quaternion.identity);
        }
    }

}
