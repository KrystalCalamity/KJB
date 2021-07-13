using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnTrigger : MonoBehaviour
{
    [SerializeField]
    string strTag;
    [SerializeField]
    int Delay = 1;

    IEnumerator EndGameDelay()
    {
        yield return new WaitForSeconds(Delay);
        SceneManager.LoadScene("Start");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().tag == strTag)
            StartCoroutine(EndGameDelay());
    }
}
