using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] protected PlayerCtrl playerCtrl;

    private void Awake() {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void checkDead()
    {
        if(this.playerCtrl.dameReceiver.IsDead()) this.Dead();
    }

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
