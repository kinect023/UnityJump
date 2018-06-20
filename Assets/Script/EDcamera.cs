﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDcamera : MonoBehaviour {

    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("bane");
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }
}