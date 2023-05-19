using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttom : MonoBehaviour
{
    public bool Active;
    public FatherButton father;
    public Color ThisColor;
    public Color GoodColor;

    private Renderer renderer;
    public bool EndPusle;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        Active = false;
        ThisColor= renderer.material.color;
     
    }

   
    public void colline()
    {
        Debug.Log("coliciono con una pelota  ");
        Active = true;
        father.IsOpen();
        renderer.material.color = GoodColor;
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        yield return new WaitForSeconds(10f);
        if (!EndPusle)
        {
            Active = false;
            renderer.material.color = ThisColor;
        }
      
    }
}
