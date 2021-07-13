using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnTrigger : MonoBehaviour
{    
    [SerializeField]
    string strTag;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == strTag)
        {
            Destroy(gameObject);
        }
    }
}
