using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BornRock : MonoBehaviour
{
    [Header("生成點")]
    public Transform pointUP;
    public Transform pointDown;
    [Header("生成物件")]
    public GameObject rockUP;
    public GameObject rockDown;

    [Header("音樂資料")]
    public MusicData musicData;

    private AudioSource aud;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
        aud.clip = musicData.music;  // 指定音樂
        aud.Play();
        Invoke("StartMusic", musicData.timeWait);   // 等待生成
    }
    private void Update()
    {
        
    }
    private void StartMusic()
    {
        // 呼叫協同程序
        StartCoroutine(SpawnPoint());
    }


    /// <summary>
    /// 生成方式
    /// </summary>
    /// <returns></returns>
    private IEnumerator SpawnPoint()
    {
        // for 迴圈
        // 陣列數量：陣列.Length - 陣列在面板上顯示的 Size
        for (int i = 0; i < musicData.points.Length; i++)
        {
            switch (musicData.points[i])
            {
                case PointType.none:
                    break;
                case PointType.Up:
                    GameObject ObjUp = Instantiate(rockUP, pointUP.position, Quaternion.identity);
                    // 物件.添加元件<元件>().欄位 = 值
                    break;
                case PointType.Down:
                    GameObject ObjDown = Instantiate(rockDown, pointDown.position, Quaternion.identity);
                    break;
                
            }
            
            // Object.Instantiate(objUp);       // 原本寫法
            // Instantiate(objUp);              // 簡寫 - 省略 Object：生成(物件)
            // 等待秒數(秒數)
            yield return new WaitForSeconds(musicData.interval);
            if (i == musicData.points.Length-1)
            {
                i = 0;
            }
        }
    }

}

