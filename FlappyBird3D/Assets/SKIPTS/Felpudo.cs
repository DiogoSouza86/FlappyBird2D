using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Felpudo : MonoBehaviour
{
    public GameObject cameraPrincipal;
    void OnTriggerEnter(Collider objeto)
    {
        if(objeto.gameObject.tag == "Finish"){
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 8.5f,-10.0f);
            GetComponent<Rigidbody>().AddTorque(new Vector3(-100.0f, -100.0f,-100.0f));
            cameraPrincipal.SendMessage("FimDeJogo");
        }
    }

    void OnTriggerExit(Collider objeto)
    {
        if(objeto.gameObject.tag == "GameController"){
            Destroy(objeto.gameObject);
            cameraPrincipal.SendMessage("MarcaPonto");
        }
    }
}
