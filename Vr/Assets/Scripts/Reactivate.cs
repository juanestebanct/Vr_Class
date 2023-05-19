using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactivate : MonoBehaviour
{
    [SerializeField]private GameObject Windows;
    [SerializeField] private GameObject Puerta;
    private void OnTriggerEnter(Collider other)
    {
        Windows.gameObject.SetActive(false);
    }
    
    public void active()
    {
        Debug.Log("se desactivo la puerta ");
        Puerta.gameObject.SetActive(false);
    }

}
