using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScoreUI : MonoBehaviour
{
    [SerializeField]
     GameObject PlayerController;
    void Update()
    {
        var _ScoreUI = PlayerController.GetComponent<MainVar>()._Score;
        GetComponent<TMPro.TextMeshProUGUI>().text = _ScoreUI.ToString();
    }
}
