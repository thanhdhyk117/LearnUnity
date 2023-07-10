using UnityEngine;
using System.Collections.Generic;
public class Spawner : MonoBehaviour 
{
    [Header("Spawner")]
    public GameObject objPrefabs;
    public GameObject spawnPos;
    public List<GameObject> objects;
    public float spawnTimer = 0f;
    public float spawnDelay = 1f;
    public int maxObject = 1;
    public string spawnPosName = "";
    public string prefabName = "";

    public int layerOrder = 0;

    private void Awake() {
        this.objPrefabs = GameObject.Find(this.prefabName);
        this.spawnPos = GameObject.Find(this.spawnPosName);
        this.objPrefabs.SetActive(false);
        this.objects = new List<GameObject>();
        this.layerOrder = (int) this.objPrefabs.transform.position.z;
    }

    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }
    protected virtual void CheckDead()
    {
        GameObject obj;

        for(int i = 0; i < objects.Count; i++)
        {
            obj = this.objects[i];

            if(obj == null){
                objects.RemoveAt(i);
            }
        }
    }

    protected virtual GameObject Spawn()
    {
        if(PlayerCtrl.instance.dameReceiver.IsDead()) return null;
        if(this.objects.Count >= this.maxObject) return null;

        this.spawnTimer +=Time.deltaTime;
        if(spawnTimer < spawnDelay) return null;
        this.spawnTimer = 0;

        Vector3 pos = this.spawnPos.transform.position;
        pos.z = this.layerOrder;
        return this.Spawn(pos);
    }

    protected virtual GameObject Spawn(Vector3 pos)
    {
        GameObject obj = Instantiate(this.objPrefabs);
        obj.transform.position = spawnPos.transform.position;
        obj.transform.parent = transform;
        obj.SetActive(true);
        this.objects.Add(obj);

        return obj;
    }
}