using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ED : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<AudioSource>().Play();
    }
}
