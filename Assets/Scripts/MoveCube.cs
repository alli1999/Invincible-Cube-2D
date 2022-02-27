using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed = 5f;
    AudioSource audio;

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(-Vector3.up * 5f);
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "Player")
        {
            audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
