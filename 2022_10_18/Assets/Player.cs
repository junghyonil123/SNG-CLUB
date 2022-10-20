using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public MainCanvas mainCanvas;

    void Start()
    {
        
    }

    Vector2 moveVector;
    public float power;
    public bool isCanAddForce = true;

    void Update()// �������Ӹ��� �ѹ��� ����Ǵ��Լ�
    {
        moveVector = new Vector2(Input.GetAxisRaw("Horizontal") * power, 0f);
        
        if (isCanAddForce == true && Input.GetAxisRaw("Horizontal") != 0)
        {
            rigidbody.AddForce(moveVector, ForceMode2D.Impulse);
            isCanAddForce = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)// ��ü�� ������ ����Ǵ� �Լ�
    {

        if (collision.gameObject.tag == "Floor")
        {
            Debug.Log("�ٴ���");
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            isCanAddForce = true;
        }

        if (collision.gameObject.tag == "DieZone")
        {
            Destroy(gameObject);
            mainCanvas.Ending();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Star")
        {
            //���� �Ծ���.
            Destroy(collision.gameObject);
            mainCanvas.starCount += 1;
        }
    }
}
