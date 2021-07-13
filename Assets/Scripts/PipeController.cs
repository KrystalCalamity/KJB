using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    GameObject _PipeSpawner;
    void Awake()
    {

        _PipeSpawner = GameObject.FindWithTag("PipeSpawner");
        GameObject PlayerController = GameObject.FindWithTag("PlayerController");
        float Score = PlayerController.GetComponent<MainVar>()._Score;


        var rb = this.GetComponent<Rigidbody>();
        var ch1 = this.transform.GetChild(0);
        var ch2 = this.transform.GetChild(1);
        var c1 = this.transform.GetChild(0).GetComponent<MeshRenderer>();
        var c2 = this.transform.GetChild(1).GetComponent<MeshRenderer>();


        if (Score < 5)
        {
            rb.velocity = new Vector3(0f, 0f, -3.5f);
        }

        if (Score >= 5 && Score <= 9)
        {
            rb.velocity = new Vector3(0f, 0f, -5f);
            c1.material.SetColor("_BaseColor", Color.blue);
            c2.material.SetColor("_BaseColor", Color.blue);
            c1.material.SetColor("_EmissionColor", Color.blue);
            c2.material.SetColor("_EmissionColor", Color.blue);
            _PipeSpawner.GetComponent<EnemySpawner>().SpawnFrequency = 2.65f;
            ch1.transform.localScale = new Vector3(1.5f, 251f, 1f);
            ch2.transform.localScale = new Vector3(1.5f, 251f, 1f);
        }

        if (Score >= 15 && Score <= 24)
        {
            rb.velocity = new Vector3(0f, 0f, -6.5f);
            c1.material.SetColor("_BaseColor", Color.red);
            c2.material.SetColor("_BaseColor", Color.red);
            c1.material.SetColor("_EmissionColor", Color.red);
            c2.material.SetColor("_EmissionColor", Color.red);
            ch1.transform.localScale = new Vector3(1.5f, 252f, 1f);
            ch2.transform.localScale = new Vector3(1.5f, 252f, 1f);
            _PipeSpawner.GetComponent<EnemySpawner>().SpawnFrequency = 1.75f;
        }
        if (Score >= 25)
        {
            rb.velocity = new Vector3(0f, 0f, -7.5f);
            c1.material.SetColor("_BaseColor", Color.black);
            c2.material.SetColor("_BaseColor", Color.black);
            c1.material.SetColor("_EmissionColor", Color.white);
            c2.material.SetColor("_EmissionColor", Color.white);
            ch1.transform.localScale = new Vector3(1.5f, 252f, 1f);
            ch2.transform.localScale = new Vector3(1.5f, 252f, 1f);
            _PipeSpawner.GetComponent<EnemySpawner>().SpawnFrequency = 1.15f;
        }
    }
}