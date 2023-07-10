using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    protected GameObject roadPrefabs;
    protected GameObject roadSpawnPos;
    protected float distance = 0;
    protected GameObject roadCurrent;

    private void Awake() {
        this.roadPrefabs = GameObject.Find("RoadPrefabs");
        this.roadSpawnPos = GameObject.Find("RoadSpawnPos");

        this.roadCurrent = this.roadPrefabs;
    }

    private void FixedUpdate() {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, this.roadCurrent.transform.position);

        if(this.distance > 40) this.Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.roadSpawnPos.transform.position;

        pos.x = 0;
        this.roadCurrent = Instantiate(this.roadPrefabs, pos, this.roadCurrent.transform.rotation);

    }
}
