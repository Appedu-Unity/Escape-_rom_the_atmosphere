using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("節拍點")]
    public Transform UPUP;
    public Transform DOWN;
    [Header("生命值")]
    static public int live = 3;
    private Rigidbody2D rig;

    private void Start()
    {
        live = 3;
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();
       
    }


    /// <summary>
    /// 跳躍
    /// </summary>
    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            transform.position = UPUP.position;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = DOWN.position;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    
}
