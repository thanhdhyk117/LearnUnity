using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public Despawner despwaner;
    public EnemyDamageReceiver damageReceiver;
    private void Awake() 
    {
        this.despwaner = GetComponent<Despawner>();
        this.damageReceiver = GetComponent<EnemyDamageReceiver>();
    }
}
