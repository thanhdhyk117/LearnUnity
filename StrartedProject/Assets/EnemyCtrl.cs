using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public Despwaner despwaner;
    private void Awake() {
        this.despwaner = GetComponent<Despwaner>();
    }
}
