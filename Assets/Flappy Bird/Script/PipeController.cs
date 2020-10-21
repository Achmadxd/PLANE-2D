using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PipeController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointUI;
    [HideInInspector] public int point;

    public void StartGame(){
        InvokeRepeating("SetPooled", 0, 1f);
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

    public void StopMovePipe() {
        foreach (var item in ObjectPooled.sharedInstance.listObject)
            item.GetComponent<PipeMove>().isMove = false;

        CancelInvoke("SetPooled");
    }

    private Vector3 RandPost() {
        var randTime = Random.Range(-.5f, 2.1f);
        return new Vector3(transform.position.x, randTime, transform.position.z);
    }

    private void PointGame() {
        pointUI.text = point.ToString();
    }
}
