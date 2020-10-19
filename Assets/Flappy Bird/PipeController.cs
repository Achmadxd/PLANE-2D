using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PipeController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointUI;
    public int point;

    private void Start()
    {
        InvokeRepeating("SetPooled", .5f, 1.7f);
    }

    private void Update()
    {
        PointGame();
    }

    private void SetPooled(){
        var bullet = ObjectPooled.sharedInstance.GetPooled();

        if(bullet != null){
            bullet.transform.position = RandPost();
            bullet.transform.rotation = transform.rotation;
            bullet.SetActive(true);
        }
    }

    private Vector3 RandPost() {
        var randTime = Random.Range(-3, 0.1f);
        Debug.Log("Random Post");
        return new Vector3(transform.position.x, randTime, transform.position.z);
    }

    private void PointGame() {
        pointUI.text = point.ToString();
    }
}
