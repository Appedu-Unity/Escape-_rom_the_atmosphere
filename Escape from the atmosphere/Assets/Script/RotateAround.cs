using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [Header("中心點")]
    public GameObject centerPoint;
    [Header("旋轉速度")]
    public float speed;

    private Vector3 axis = new Vector3(0,0,1);  //旋轉軸

    private void Start()
    {
        //搜尋中心點物件
        centerPoint = GameObject.Find("Ball"); 
    }
    void Update()
    {
        //取得中心點向量
        Vector3 center = centerPoint.transform.position; 

        //以center為圓心以axis為旋轉軸旋轉，速度為speed
        transform.RotateAround(center, axis, speed);
    }
}
