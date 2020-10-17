using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float speedMove;

    private void Start()
    {
        var randTime = Random.Range(-3, 0.1f);
        transform.position = new Vector3(transform.position.x, randTime, transform.position.z);
    }

    private void Update()
    {
        transform.position -= transform.right * speedMove * Time.deltaTime;

        if(transform.position.x < -13f)
            gameObject.SetActive(false);
    }
}
