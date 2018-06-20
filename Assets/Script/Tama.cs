using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tama : MonoBehaviour {

    float speed = 0;
    float Speed = 0;
    Vector2 startPos;

    void Start()
    {
    }

    void Update()
    {

        // スワイプの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            // マウスをクリックした座標
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // マウスを離した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            float SwipeLength = endPos.y - startPos.y;

            // スワイプの長さを初速度に変換する
            this.speed = swipeLength / 5000.0f;
            this.Speed = SwipeLength / 5000.0f;

            // 効果音再生（追加）
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(-this.speed, -this.Speed, 0);
        this.speed *= 0.9f;
        this.Speed *= 0.9f;
    }
}
