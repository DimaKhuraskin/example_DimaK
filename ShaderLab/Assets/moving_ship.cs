using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_ship : MonoBehaviour
{
    public float speed;
    void Update()
    {
        gameObject.transform.Translate(0, speed, 0);
    }
}
