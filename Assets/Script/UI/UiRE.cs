using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiRE : MonoBehaviour {

    public void OnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Earth1");
        }
    }
}
