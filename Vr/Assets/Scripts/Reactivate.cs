using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactivate : MonoBehaviour
{
    [SerializeField]private GameObject Windows;
    private void OnTriggerEnter(Collider other)
    {
        Windows.gameObject.SetActive(false);
    }
}
