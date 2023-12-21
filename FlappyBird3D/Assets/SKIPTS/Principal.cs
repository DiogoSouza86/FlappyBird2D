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
        InvokeRepeating("CriaObstaculo", 1, 0.75f);
    }

    // Update is called once per frame
    void CriaCerca()
    {
        Instantiate(cerca);
    }

    void CriaObstaculo()
    {
        int sorteiaObjeto = Random.Range(1,5);

        float posicaoXrandom = Random.Range(-2.78f, 2.28f);
        float posicaoYrandom = Random.Range(0.98f, 3.25f);
        float rotacaoYrandom = Random.Range(0.0f, 360.0f);


        switch(sorteiaObjeto){
        case 1: Instantiate(arbusto); break;
        case 2: Instantiate(pedra); break;
        case 3: Instantiate(nuvem); break;
        case 4: Instantiate(canos); break;
        default: break;
        }

    }
}
