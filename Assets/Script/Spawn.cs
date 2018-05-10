using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    void Awake()
    {
        Invoke("SpawnNext", 2f);
    }
    void SpawnNext()
    {
        GameObject FallingEggs = Instantiate(gameObject);
        FallingEggs.transform.position = new Vector3(0, -1 + transform.localScale.y / 2, 0);
    }
}
