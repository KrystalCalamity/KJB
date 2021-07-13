using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelOnUIButtonPush : MonoBehaviour
{
    public Button _Button;

    void Start()
    {
        Button _btn = _Button.GetComponent<Button>();
        _btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Start");
        Debug.Log("test");
    }
}
