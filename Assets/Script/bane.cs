using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bane : MonoBehaviour {

    float d = 1f;
    Vector2 defaultPosition;
    bool clickFlag = false;
    bool checkFlag = false;
    public static bool gameFlag = true;

    void Start()
    {
        d = 100.0f * Time.deltaTime;
        defaultPosition = new Vector2(transform.position.x, transform.position.y);
    }

    void Update()
    {
        if (!bane.gameFlag)
        {
            return;
        }
        float x = Input.mousePosition.x;
        float y = Input.mousePosition.y;
        Vector2 v = Camera.main.WorldToScreenPoint(transform.position);
        float dx = x - v.x;
        float dy = y - v.y;
        if (dx > 150)
        {
            dx = 150f;
        }
        if (dy > 150)
        {
            dy = 150f;
        }

        if (!clickFlag)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(d * dx, d * dy));
                //clickFlag = true;
            }
        }
        else
        {
            if (Input.GetMouseButtonUp(0))
            {
                //checkFlag = true;
            }
        }
    }
}
