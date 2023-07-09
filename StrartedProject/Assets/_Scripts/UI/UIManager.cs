using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject btnGameOver;

    void Awake()
    {
        this.btnGameOver = GameObject.Find("btnGameOver");
        btnGameOver.SetActive(false);

        UIManager.instance = this;
    }
}
