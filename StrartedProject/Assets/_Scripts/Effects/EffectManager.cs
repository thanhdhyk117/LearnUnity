using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    static public EffectManager instance;

    public List<GameObject> effect;

    private void Awake() {
        EffectManager.instance = this;

        this.LoadEffect();
    }

    protected virtual void LoadEffect()
    {
        this.effect = new List<GameObject>();

        foreach(Transform child in transform)
        {
            this.effect.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
    }

    public virtual void SpawnVFX(string effectName, Vector3 position, Quaternion rot)
    {
        GameObject effect = this.Get(effectName);
        GameObject newEffect = Instantiate(effect, position, rot);
        newEffect.gameObject.SetActive(true);
    }

    protected virtual GameObject Get(string effectName)
    {
        foreach(GameObject child in this.effect)
        {
            if(child.name == effectName) return child;
        }

        return null;
    }
}
