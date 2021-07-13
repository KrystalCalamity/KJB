using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnOnTrigger : MonoBehaviour
{
    [SerializeField]
    string strTag;
    [SerializeField]
    bool bSpawnOther = false;
    [SerializeField]
    bool bSpawnSelf = true;
    [SerializeField]
    GameObject SpawnObject;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().tag == strTag)
            if (bSpawnSelf == true)
                Instantiate(SpawnObject, transform.position, Quaternion.identity);
            if (bSpawnOther == true)
                Instantiate(SpawnObject, collision.gameObject.transform.position, Quaternion.identity);
    }
}
