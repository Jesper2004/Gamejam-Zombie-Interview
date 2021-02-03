using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    private GameObject Platform;
    private float resetPosition = 30f;
    void Start()
    {
		Platform = GetComponent<GameObject>();
    }

    void Update()
    {
        if (transform.position.x == 20f)
        {
            transform.position = new Vector3(resetPosition, transform.position.y);
        }
    }
}
