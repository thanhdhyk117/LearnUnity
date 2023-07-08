using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameSender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.name);

        DameReceiver dameReceiver = collision.GetComponent<DameReceiver>();
        dameReceiver.Receive(1);

    }
}
