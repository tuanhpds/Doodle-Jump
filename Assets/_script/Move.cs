using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public int Move1;
    public int JumpHeight;
    private Rigidbody2D rb;
    public bool JumpOK;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
     void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Move1= 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Move1 = -1;
        }
        else
        {
            Move1 = 0;
        }
        transform.Translate(Vector2.right * Move1 * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && JumpOK)
        {
            rb.AddForce(Vector2.up * JumpHeight, ForceMode2D.Impulse);
        }
                                     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "san") 
        {
            JumpOK = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "san") 
        {
            JumpOK = false;
        }
    }
}
