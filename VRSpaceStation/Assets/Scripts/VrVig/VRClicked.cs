﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRClicked : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AutoAdd(GameObject _Module)
    {
        _Module.AddComponent<VRObjectControllerAddScript>().AutoAddScript();
    }
}
