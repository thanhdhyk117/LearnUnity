using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{
    private void Reset() 
    {
        this.spawnPosName = "BombSpawnPos";
        this.prefabName = "BombPrefab";
        this.maxObject = 7;
    }

    // protected override void Spawn()
    // {
    //     spawnTimer += Time.deltaTime * 2;
    //     if(spawnTimer < spawnDelay) return;
    //     this.spawnTimer = 0;

    //     if(objects.Count >= this.maxObject) return;
    //     GameObject  boom =  Instantiate(objPrefabs);
    //     boom.transform.parent = transform;

    //     boom.name = "Boom #";
    //     boom.transform.position = spawnPos.transform.position;
    //     boom.SetActive(true);
    //     boom.transform.parent = transform;

    //     this.objects.Add(boom);
    // }
}
