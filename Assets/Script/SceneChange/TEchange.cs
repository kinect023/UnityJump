using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TEchange : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<AudioSource>().Play();
        FadeManager.Instance.LoadScene("Earth1", 1.0f);
    }
}
