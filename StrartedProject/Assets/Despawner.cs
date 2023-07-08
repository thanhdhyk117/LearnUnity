using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    public virtual void Despwan()
    {
        Destroy(gameObject);
    }
}
