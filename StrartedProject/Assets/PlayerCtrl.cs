using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public DamageReceiver dameReceiver;
    public PlayerStatus playerStatus;


    private void Awake() {
        this.dameReceiver = GetComponent<DamageReceiver>();
        this.playerStatus = GetComponent<PlayerStatus>();
    }
}
