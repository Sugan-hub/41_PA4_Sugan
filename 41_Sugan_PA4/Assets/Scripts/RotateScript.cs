﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
 
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.RotateAround(cube.transform.position, new Vector3(0, 1, 0), 180 * Time.deltaTime);
    }
}
 