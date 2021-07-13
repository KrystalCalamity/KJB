using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddPointOnTrigger : MonoBehaviour
{
    public string strTag;

    [SerializeField]
    GameObject PlayerController;

    public GameObject PointSound;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == strTag)
        {
            PlayerController.GetComponent<MainVar>()._Score += 1;
            if (PointSound != null)
            {
                Instantiate(PointSound, transform.position, Quaternion.identity);
            }
        }

    }
}
