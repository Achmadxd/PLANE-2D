using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    Rigidbody2D rb;
    [SerializeField] float speedMove;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
            CreatePrefab();

        if(Input.GetKeyDown(KeyCode.Z))
            SetPooled();

        MovePlayer();
    }

    private void MovePlayer() {
        Vector2 v2 = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        rb.velocity = v2 * speedMove * Time.deltaTime;
    }

    private void CreatePrefab() {
        Instantiate(prefab, transform.GetChild(0).position, transform.GetChild(0).rotation);
    }

    private void SetPooled(){
        var bullet = ObjectPooled.sharedInstance.GetPooled();

        if(bullet != null){
            bullet.transform.position = transform.GetChild(0).position;
            bullet.transform.rotation = transform.GetChild(0).rotation;
            bullet.SetActive(true);
        }
    }
}