using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnity : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jumpValue;
    [SerializeField] PipeController controller;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
            Jumper();
    }

    void Jumper() {
        rb.AddForce(Vector2.up * jumpValue);
        Debug.Log("lompat");        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("pipe"))
            controller.point++;
    }
}
