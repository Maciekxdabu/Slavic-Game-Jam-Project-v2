using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject []bandits;
    public Vector2 cooldownRange;

    private float []cooldowns = { 0, 0, 0, 0, 0, 0};

    void Start()
    {
        cooldowns[0] = Random.Range(cooldownRange.x, cooldownRange.y);
        cooldowns[1] = Random.Range(cooldownRange.x, cooldownRange.y);
        cooldowns[2] = Random.Range(cooldownRange.x, cooldownRange.y);
        cooldowns[3] = Random.Range(cooldownRange.x, cooldownRange.y);
        cooldowns[4] = Random.Range(cooldownRange.x, cooldownRange.y);
        cooldowns[5] = Random.Range(cooldownRange.x, cooldownRange.y);
    }

    void Update()
    {
        for (int i=0; i<bandits.Length; i++)
        {
            if (bandits[i].activeInHierarchy == false)
            {
                cooldowns[i] -= Time.deltaTime;

                if (cooldowns[i] <= 0)
                {
                    bandits[i].SetActive(true);
                    cooldowns[i] = Random.Range(cooldownRange.x, cooldownRange.y);
                }
            }
        }
    }
}
