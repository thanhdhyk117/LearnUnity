using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected GameObject enemyPrefabs;

    protected float timer = 0;
    protected float delay = 2f;

    private void Awake() {
        this.enemyPrefabs = GameObject.Find("EnemyPrefabs");
        this.enemyPrefabs.SetActive(false);
    }

    private void Update() {
        this.Spawn();
    }

    protected virtual void Spawn()
    {
        this.timer +=Time.deltaTime;
        if(timer < delay) return;
        this.timer = 0;

        GameObject enemy = Instantiate(this.enemyPrefabs);
        enemy.transform.position = transform.position;
        enemy.SetActive(true);
    }
}
