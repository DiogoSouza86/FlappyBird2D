using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -15f){
            Destroy(this.gameObject);
        }
    }
}
