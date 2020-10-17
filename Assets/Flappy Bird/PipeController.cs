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
        InvokeRepeating("SetPooled", .5f, 1.1f);
    }

    private void Update()
    {
        PointGame();
    }

    private void SetPooled(){
        var bullet = ObjectPooled.sharedInstance.GetPooled();

        if(bullet != null){
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            bullet.SetActive(true);
        }
    }

    private void PointGame() {
        pointUI.text = point.ToString();
    }
}
