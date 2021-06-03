﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerBoy : MonoBehaviour
{
    [SerializeField] float x = 0;
    [SerializeField] float y = 1;
    [SerializeField] float z = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x, y, z));
    }
}
