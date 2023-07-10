using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    private void Reset() 
    {
        this.spawnPosName = "EnemySpawnPos";
        this.prefabName = "EnemyPrefabs";
    }

    // protected override void Spawn()
    // {

    //     if(PlayerCtrl.instance.dameReceiver.IsDead()) return;

    //     if(this.objects.Count >= this.maxObject) return;

    //     this.spawnTimer +=Time.deltaTime;
    //     if(spawnTimer < spawnDelay) return;
    //     this.spawnTimer = 0;

    //     GameObject enemy = Instantiate(this.objPrefabs);
    //     enemy.transform.position = spawnPos.transform.position;

    //     enemy.SetActive(true);

    //     this.objects.Add(enemy);
    // }
}
