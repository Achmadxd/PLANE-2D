using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float speedMove;
    public bool isMove = true;

    private void Update()
    {
        if(isMove)
            transform.position -= transform.right * speedMove * Time.deltaTime;

        if(transform.position.x < -13f){
            gameObject.SetActive(false);
        }
    }
}
