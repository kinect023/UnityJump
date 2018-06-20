using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ETchange : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        //GetComponent<AudioSource>().Play();
        FadeManager.Instance.LoadScene("Title", 2.5f);
    }
}
