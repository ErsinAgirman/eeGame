using System.Collections;
using System.Collections.Generic;
using Microsoft.Cci;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
