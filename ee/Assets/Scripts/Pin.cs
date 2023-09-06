using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Pin : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public bool isPinned;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    void FixedUpdate()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }

        /*
        Fizik Zaman Adımlarını Sabitleme: Fizik tabanlı oyunlarda,
        hareketi fizik zaman adımlarıyla yapmak daha istikrarlı sonuçlar verebilir.
        Bu nedenle iğnelerin hareketini fizik adımlarına bağlamak için FixedUpdate
        fonksiyonu mantıklıdır. FixedUpdate, sabit zaman aralıklarıyla çalışır ve
        fiziksel güncellemeler için daha uygun bir yerdir.
        */
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "BigCircle")
        {
            transform.SetParent(other.transform);
            Score.PinCount++;
            isPinned = true;

            //other.GetComponent<Rotate>().speed += 20f;
            other.GetComponent<Rotate>().speed *= -1;
        }
        else if (other.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }    
    }
}
