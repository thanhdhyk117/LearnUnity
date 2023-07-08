using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public List<GameObject> minions;

    public float spwanTimer = 0;
    public float delayTimer = 1f;

    public GameObject minionPrefab;

    public int index;
    void Start()
    {
        index  = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.Spwan();
        checkMinionDead();
    }

    void Spwan()
    {
        spwanTimer += Time.deltaTime * 2;
        if(spwanTimer < delayTimer) return;
        this.spwanTimer = 0;

        if(minions.Count >= 7) return;
        GameObject  minion =  Instantiate(minionPrefab);

        minion.name = "Boom #" + index;
        minion.transform.position = transform.position;
        minion.SetActive(true);

        this.minions.Add(minion);
    }

    void checkMinionDead()
    {
        GameObject minion;

        for(int i = 0; i < minions.Count; i++)
        {
            minion = this.minions[i];

            if(minion == null){
                minions.RemoveAt(i);
            }
                
        }
    }
}
