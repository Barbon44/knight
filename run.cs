using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class run : MonoBehaviour
{
    public float jumpHeight = 1;
    public float moveSpeed = 1;
    public bool jamping;
    int a = 1, b = 1;

    public void Res()
    {
        SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Graund")
        {
            jamping = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            if (jamping == true)
            {
                GetComponent<Rigidbody2D>().velocity += new Vector2(0, jumpHeight);
                jamping = false;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(moveSpeed,0);
            a = 1;
            Flip();
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity -= new Vector2(moveSpeed, 0);
            a = 2;
            Flip();
        }
    }

    private void Flip()
    {
        if (b != a)
        {
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
            b = a;
        }
    }
}
