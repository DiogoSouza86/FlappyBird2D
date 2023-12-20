using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Principal : MonoBehaviour
{
    public GameObject cerca;
    public GameObject nuvem;
    public GameObject pedra;
    public GameObject arbusto;
    public GameObject canos;

    void Start()
    {
        InvokeRepeating("CriaCerca", 1, 0.4f);
    }

    // Update is called once per frame
    void CriaCerca()
    {
        Instantiate(cerca);
    }
}
