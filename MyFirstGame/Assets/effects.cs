﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Capsulekuat") {
        
        transform.Rotate(3, 0, 0);
        }

        if (gameObject.name == "Capsulekuat(Clone)") {
        
        transform.Rotate(3, 0, 0);
        }

        if (gameObject.name == "coin") {
        
        transform.Rotate(0, 0, 3);
        }
        if (gameObject.name == "coin(Clone)") {
        
        transform.Rotate(0, 0, 3);
        }


    }

}
