using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken : MonoBehaviour
{
    public int CountDamage;
   public void DestroyObject()
   {
        CountDamage--;
        if (CountDamage<=0)
        {
            Destroy(gameObject);
          
        }
        Debug.Log("casi destruido");

    }
}
