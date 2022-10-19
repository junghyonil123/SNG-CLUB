using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody;


    void Start()
    {
        
    }

    Vector2 moveVector;
    public float power;
    public bool isCanAddForce = true;

    void Update()// 매프레임마다 한번씩 실행되는함수
    {
        moveVector = new Vector2(Input.GetAxisRaw("Horizontal") * power, 0f);
        
        if (isCanAddForce == true && Input.GetAxisRaw("Horizontal") != 0)
        {
            rigidbody.AddForce(moveVector, ForceMode2D.Impulse);
            isCanAddForce = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)// 물체와 닿을때 실행되는 함수
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        isCanAddForce = true;
    }
}
