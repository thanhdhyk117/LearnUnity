using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameSender : MonoBehaviour
{
    protected EnemyCtrl enemyCtrl;

    private void Awake() {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.name);

        this.enemyCtrl.despwaner.Despwan();
        
        DamageReceiver dameReceiver = collision.GetComponent<DamageReceiver>();
        dameReceiver.Receive(1);

    }
}
