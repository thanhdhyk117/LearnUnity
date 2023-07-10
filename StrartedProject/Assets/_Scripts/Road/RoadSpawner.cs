using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    protected GameObject roadPrefabs;
    protected GameObject roadSpawnPos;
    protected float distance = 0;
    protected GameObject roadCurrent;
    protected int roadLayerOrder = 0;

    private void Awake() 
    {
        this.roadPrefabs = GameObject.Find("RoadPrefabs");
        this.roadSpawnPos = GameObject.Find("RoadSpawnPos");
        this.roadPrefabs.SetActive(false);
        this.roadCurrent = this.roadPrefabs;
        this.roadLayerOrder = (int) this.roadPrefabs.transform.position.z;

        this.Spawn(this.roadPrefabs.transform.position);
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
        pos.z = roadLayerOrder;

        this.Spawn(pos);
    }

    protected virtual void Spawn(Vector3 position)
    {
        this.roadCurrent = Instantiate(this.roadPrefabs, position, this.roadCurrent.transform.rotation);
        this.roadCurrent.SetActive(true);

        this.roadCurrent.transform.parent = transform;
    }
}
