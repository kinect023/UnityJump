using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EMchange : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<AudioSource>().Play();
        FadeManager.Instance.LoadScene("Moon2", 1.5f);
    }
}