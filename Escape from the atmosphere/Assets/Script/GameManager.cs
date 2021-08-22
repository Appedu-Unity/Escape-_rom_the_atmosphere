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
    public float high=0.1f;
    [Header("生命文字")]
    public Text textLive;
    [Header("失敗文字")]
    public GameObject gameOver;


    void Start()
    {
        player = GameObject.Find("Player");
        ball = GameObject.Find("Earth");

    }   
    void Update()
    {
        Text();
        GameOver();
    }

    /// <summary>
    /// 目前分數
    /// </summary>
    private void Text()
    {
        high += 0.01f;
        textHigh.text = Mathf.Round(high) + " M  ";
        textLive.text = "   Live : " + Player.live; 
    }

    private void GameOver()
    {
        if(Player.live <= 0)
        {
            
            enabled = false;
            gameOver.SetActive(true);
        }

    }
}
