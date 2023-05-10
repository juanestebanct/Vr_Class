using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public GameObject ObjecTp;
    public GameObject TpZone;
    public int CountLevel;
 

    public void OnTp()
    {
        ObjecTp.transform.position = TpZone.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        OnTp();
        Debug.Log("tp");
        if (CountLevel==2)
        {
            TimerExit.Instance.StarTime = true;
            Debug.Log("Inicia el cronometro");
        }
    }
}
