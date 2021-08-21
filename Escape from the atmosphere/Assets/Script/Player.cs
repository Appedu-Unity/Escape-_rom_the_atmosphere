using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("跳躍高度")]
    public float jump = 5;
    [Header("踩地板判定")]
    public bool isGround = true;   

    private Rigidbody2D rig;


    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Jump(); 
    }


    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (isGround && Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(new Vector2(0, jump*100));
        }
    }

    
}
