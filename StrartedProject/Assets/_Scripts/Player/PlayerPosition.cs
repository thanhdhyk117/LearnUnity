using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public List<GameObject> booms;

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

        if(booms.Count >= 7) return;
        GameObject  boom =  Instantiate(minionPrefab);

        boom.name = "Boom #" + index;
        boom.transform.position = transform.position;
        boom.SetActive(true);
        boom.transform.parent = transform;

        this.booms.Add(boom);
    }

    void checkMinionDead()
    {
        GameObject minion;

        for(int i = 0; i < booms.Count; i++)
        {
            minion = this.booms[i];

            if(minion == null){
                booms.RemoveAt(i);
            }
        }
    }
}
