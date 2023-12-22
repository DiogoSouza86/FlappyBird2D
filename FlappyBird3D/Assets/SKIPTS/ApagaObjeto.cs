using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagaObjeto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroiObjeto", 1.5f);
    }

    // Update is called once per frame
    void DestroiObjeto()
    {
        Destroy(this.gameObject);
    }
}
