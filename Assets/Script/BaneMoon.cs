using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaneMoon : MonoBehaviour {

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
        if (Input.GetMouseButtonDown(0) && rigid2d.position.y==-2.3f)
        {
            // マウスをクリックした座標
            this.startPos = Input.mousePosition;
            animator.SetTrigger("banetame");
        }
        else if (Input.GetMouseButtonUp(0) &&  rigid2d.position.y == -2.3f)
        {
            // マウスを離した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            float SwipeLength = endPos.y - startPos.y;

            // スワイプの長さを初速度に変換する
            this.speed = swipeLength / 2500.0f;
            this.Speed = SwipeLength / 2500.0f;

            // 効果音再生（追加）
            GetComponent<AudioSource>().Play();
            animator.SetTrigger("banej");
        }

        transform.Translate(-this.speed, -this.Speed, 0);
        this.speed *= 1.0f;
        this.Speed *= 1.0f;
    }
}