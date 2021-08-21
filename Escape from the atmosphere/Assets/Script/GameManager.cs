using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("玩家物件")]
    public GameObject player;
    [Header("地球物件")]
    public GameObject ball;
    [Header("高度文字")]
    public Text textHigh;
    public float high;

    void Start()
    {
        player = GameObject.Find("Player");
        ball = GameObject.Find("Ball");

        //取得高度文字
        textHigh = GameObject.Find("High").GetComponent<Text>();

        
    }

    
    void Update()
    {
        High();
    }

    
    /// <summary>
    /// 目前高度
    /// </summary>
    private void High()
    {
        high = Mathf.Round(player.transform.position.y - ball.transform.position.y)-4;
        textHigh.text = high + " M  ";
    }

}
