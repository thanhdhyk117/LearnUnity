using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemies;
    public int maxEnemy = 1;

    [SerializeField] protected GameObject enemyPrefabs;
    protected GameObject enemySpawnPos;
    
    protected float timer = 0;
    protected float delay = 2f;

    private void Awake() {
        this.enemyPrefabs = GameObject.Find("EnemyPrefabs");
        this.enemySpawnPos = GameObject.Find("EnemySpawnPos");

        this.enemyPrefabs.SetActive(false);
        
        this.enemies = new List<GameObject>();
    }

    private void Update() {
        this.Spawn();
        CheckEnemyDead();
    }

    protected virtual void Spawn()
    {

        if(PlayerCtrl.instance.dameReceiver.IsDead()) return;

        if(this.enemies.Count >= this.maxEnemy) return;

        this.timer +=Time.deltaTime;
        if(timer < delay) return;
        this.timer = 0;

        GameObject enemy = Instantiate(this.enemyPrefabs);
        enemy.transform.position = enemySpawnPos.transform.position;

        enemy.SetActive(true);

        this.enemies.Add(enemy);
    }

    void CheckEnemyDead()
    {
        GameObject enemy;
        for(int i = 0; i < this.enemies.Count; i++)
        {
            enemy = this.enemies[i];
            if(enemy == null) this.enemies.RemoveAt(i);
        }
    }
}
