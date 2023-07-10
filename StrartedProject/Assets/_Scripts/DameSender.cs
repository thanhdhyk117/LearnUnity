using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameSender : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        DamageReceiver dameReceiver = collision.GetComponent<DamageReceiver>();
        
        if(dameReceiver == null) return;
        
        dameReceiver.Receive(1);
    }
}
