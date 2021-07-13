using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfAfterTime : MonoBehaviour
{
    [SerializeField]
    float fTimer = 0;

    void Update()
    {
        fTimer -= Time.deltaTime;
        if (fTimer <= 0)
            Destroy(this.gameObject);
    }
}
