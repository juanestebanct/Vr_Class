using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Punch : MonoBehaviour
{
   public Rigidbody body;
    public float Magnitud;

    private void Start()
    {
        body = GetComponent<Rigidbody>();   
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if ( collision.gameObject.tag == "Destroider" && (Magnitud*40)>5)
        {
            Debug.Log("destroy this object");
            collision.gameObject.GetComponent<Broken>().DestroyObject();
        }
    }
    private void Update()
    {
        Magnitud = body.velocity.magnitude;
      //  Debug.Log("fueza "+Magnitud*10f);
    }
}
