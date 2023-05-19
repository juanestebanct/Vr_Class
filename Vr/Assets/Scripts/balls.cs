using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("colliciono");
        if (collision.gameObject.tag == "Buttons")
        {
            Debug.Log("colliciono con el boton" +
                "");
        }
    }
}
