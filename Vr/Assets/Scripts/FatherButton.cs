using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FatherButton : MonoBehaviour
{
    public Buttom[] buttom;
    public GameObject Door; 
    void Start()
    {
        
    }

    public void IsOpen()
    {
        print("entro a father");
        foreach (var buttom in buttom) {
            if (buttom.Active)
            {
                Debug.Log("boton activado" + buttom);
            }
            else
            {
                return;
            }
       
        }
        foreach (var buttom in buttom)
        {

            buttom.EndPusle = true;

        }
        Door.gameObject.SetActive(false);


        Debug.Log("pasa o no");
    }
}
