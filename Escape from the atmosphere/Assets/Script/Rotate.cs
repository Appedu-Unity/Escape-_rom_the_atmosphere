using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Header("旋轉速度")]
    public float speed = 1;
    
    void Update()
    {
        transform.Rotate(0, 0, speed);
    }
}
