using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour {

    bool m_xPlus = true;

    void Start()
    {

    }

    void Update()
    {
        if (m_xPlus)
        {
            transform.position += new Vector3(3f * Time.deltaTime, 0f, 0f);
            if (transform.position.x >= 2)
                m_xPlus = false;
        }
        else
        {
            transform.position -= new Vector3(3f * Time.deltaTime, 0f, 0f);
            if (transform.position.x <= -2)
                m_xPlus = true;
        }
    }
}
