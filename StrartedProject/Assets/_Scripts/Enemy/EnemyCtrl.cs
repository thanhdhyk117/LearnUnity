using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public Despawner despwaner;
    private void Awake() 
    {
        this.despwaner = GetComponent<Despawner>();
    }
}
