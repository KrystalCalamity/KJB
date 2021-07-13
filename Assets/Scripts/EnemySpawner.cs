using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject EnemyType;
    public float SpawnFrequency;
    [SerializeField]
    float SpawnLimit;
    [SerializeField]
    bool UnlimitedSpawn = true;
    [SerializeField]
    bool _SpawnOnAwake = true;
    [SerializeField]
    bool Enabled = false;
    public bool _SpawnJitter = false;
    float fTimer;
    Vector3 SpawnLocation;


    void Awake()
    {
        fTimer = SpawnFrequency;
        if (_SpawnOnAwake == true)
        {
            SpawnLocation = this.transform.position;
            Instantiate(EnemyType, SpawnLocation, Quaternion.identity, transform.parent);
            _SpawnOnAwake = false;
        }
    }

    void Update()
    {
        if (Enabled == true)
        {
            SpawnLocation = this.transform.position;

            if (SpawnLimit <= 0 && !UnlimitedSpawn)
            {
                Enabled = false;
                return;
            }

            if (_SpawnJitter == true)
            {
                SpawnLocation += this.transform.localScale * (Random.value - 0.5f);
            }

            if (fTimer <= 0)
            {
                fTimer = SpawnFrequency;
                if (!UnlimitedSpawn) SpawnLimit -= 1;
                Instantiate(EnemyType, SpawnLocation, Quaternion.identity, transform.parent);
            }
        }
        else
            Destroy(this.gameObject);
    }

    void FixedUpdate()
    {
        fTimer -= Time.deltaTime;
    }
}
