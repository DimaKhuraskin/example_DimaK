using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotWalking : MonoBehaviour
{
    void Update()
    {
        if (transform.position.z <= -5f) {
            transform.Translate(0, 0, 0.08f);
        }
    }
}
