using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiH : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadScene("Title");
    }
}

