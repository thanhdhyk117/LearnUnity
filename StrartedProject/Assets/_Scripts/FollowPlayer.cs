using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 27f;
    public float disLimit = 3f;

    public float randomPos = 0;
    
    private void Start()
    {
        this.player = PlayerCtrl.instance.transform;

        this.randomPos = Random.Range(-6, 6);
    }
    void FixedUpdate()
    {
        this.Follow();
    }

    void Follow()
    {
        Vector3 pos = player.position;
        pos.x = this.randomPos;

        Vector3 distance = pos - transform.position;

        if(distance.magnitude >= disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * disLimit;
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.fixedDeltaTime);
        }
    }
}
