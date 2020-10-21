using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] float speedMove;

    private void Update()
    {
        transform.position += transform.up * speedMove * Time.deltaTime; 
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.CompareTag("enemy"))
            gameObject.SetActive(false);
    }
}
