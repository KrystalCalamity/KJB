using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnKeyPush : MonoBehaviour
{

    [SerializeField]
    KeyCode keyRestart;
    [SerializeField]
    KeyCode keyMenu;


    void Update()
    {
        if (Input.GetKey(keyRestart))
        {
            SceneManager.LoadScene("Start");
        }

        if (Input.GetKey(keyRestart))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
