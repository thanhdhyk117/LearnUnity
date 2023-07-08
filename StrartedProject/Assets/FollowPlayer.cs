using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    protected float speed = 7f;
    protected float disLimit = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Follow();
    }

    void Follow()
    {
        Vector3 distance = player.position - transform.position;

        if(distance.magnitude >= disLimit)
        {
            Vector3 targetPoint = player.position - distance.normalized * disLimit;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPoint, speed * Time.deltaTime);
        }
        
    }
}
