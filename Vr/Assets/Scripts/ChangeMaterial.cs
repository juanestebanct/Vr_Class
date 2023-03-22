using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField] Transform targetObject;
    [SerializeField] Material newMaterial;


    public void ChangeToNewMaterial()
    {
        targetObject.GetComponent<Renderer>().material = newMaterial;
    }

}
