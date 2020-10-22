using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnity : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jumpValue;
    [SerializeField] PipeController controller;
    AudioSource jumpVoice;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpVoice = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
            Jumper();
    }

    void Jumper() {
        rb.AddForce(Vector2.up * jumpValue);
        jumpVoice.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("pipe"))
            controller.point++;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("enemy")){
            controller.StopMovePipe();
            Destroy(GetComponent<Animator>());
        }
    }
}
