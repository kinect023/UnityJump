using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bane1 : MonoBehaviour {

    float speed = 0;
    float Speed = 0;
    Vector2 startPos;
    Animator animator;
    Rigidbody2D rigid2d;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigid2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        // スワイプの長さを求める
        if (Input.GetMouseButtonDown(0) && rigid2d.velocity.y == 0)
        {
            // マウスをクリックした座標
            this.startPos = Input.mousePosition;
            animator.SetTrigger("banetame");

        }
        else if (Input.GetMouseButtonUp(0) && rigid2d.velocity.y == 0)
        {
            // マウスを離した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            float SwipeLength = endPos.y - startPos.y;

            // スワイプの長さを初速度に変換する
            this.speed = swipeLength / 1500.0f;
            this.Speed = SwipeLength / 1500.0f;

            // 効果音再生（追加）
            GetComponent<AudioSource>().Play();
            animator.SetTrigger("banej");
        }

        transform.Translate(-this.speed, -this.Speed, 0);
        this.speed *= 0.9f;
        this.Speed *= 0.9f;

        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("Earth1");
        }
    }
}