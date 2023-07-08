using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected int hp = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Receive(int damage)
    {
        print("Hp se bị tru đi");
        hp -= damage; 
    }
}
