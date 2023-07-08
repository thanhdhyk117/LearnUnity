using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    float playerPosX;
    public List<GameObject> minions;
    // Start is called before the first frame update

    private void Start() {
        minions = new List<GameObject>();
    }
    void Spwan()
    {
        if(minions.Count > 7) return;
        GameObject minion = new GameObject("Minion");
        this.minions.Add(minion);
    }
    // Update is called once per frame
    void Update()
    {
        this.playerPosX = transform.position.x;

        if(this.playerPosX >= 7) this.Spwan();
    }
}
