using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float Speed = 5f; // 속도
    public float jumpForce = 10f; // 점프 높이
    private bool isOnGround = false;
    private Rigidbody2D rb;

    public float minX = -10f;
    public float maxX = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * Speed, rb.velocity.y); // Vector2에선 델타타임 넣으니까 이상함.
        if (isOnGround && Input.GetKeyDown(KeyCode.Space)) // 점프
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        Vector3 pos = transform.position; // 화면밖에 못나감.
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collision) { //위에 잘 있을떄
        if (collision.gameObject.CompareTag("Clone")){
            GameManager.Instance.GameOver(); // 게임 오버
        }
        if(collision.collider.tag == "Ground") {
            isOnGround = true;
        }
        
    }

    void OnCollisionExit2D(Collision2D collision) { //벗어났을떄
        if(collision.collider.tag == "Ground") {
            isOnGround = false;
        }       
    }

}
