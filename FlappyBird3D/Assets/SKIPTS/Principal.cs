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

        float posicaoXrandom = Random.Range(-2.8f, 2.53f);
        float posicaoYrandom = Random.Range(0.9f, 3.25f);
        float rotacaoYrandom = Random.Range(0.0f, 360.0f);

        GameObject novoObjeto = new GameObject();

        switch(sorteiaObjeto){
        case 1: novoObjeto = Instantiate(arbusto); posicaoYrandom = novoObjeto.transform.position.y; break;
        case 2: novoObjeto = Instantiate(pedra); posicaoYrandom = novoObjeto.transform.position.y;break;
        case 3: novoObjeto = Instantiate(nuvem); break;
        case 4: novoObjeto = Instantiate(canos); posicaoYrandom = Random.Range(-2.16f, 0.01f); posicaoXrandom = novoObjeto.transform.position.x; break;
        default: break;
        }

        novoObjeto.transform.position = new Vector3(posicaoXrandom, posicaoYrandom, novoObjeto.transform.position.z);
        novoObjeto.transform.rotation = Quaternion.Euler(novoObjeto.transform.rotation.x, rotacaoYrandom, novoObjeto.transform.rotation.y);

    }
}
