using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeLevel : MonoBehaviour
{
    public GameObject ObjecTp;
    public GameObject TpZone;
    public int CountLevel;
    public GameObject tpfacade;

    public UnityEvent OnColliderEnter = new UnityEvent() ;
    public void OnTp()
    {
        ObjecTp.transform.position = TpZone.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        OnColliderEnter.Invoke();
        //OnTp();
        Debug.Log("tp");
        if (CountLevel==2)
        {
            TimerExit.Instance.StarTime = true;
            Debug.Log("Inicia el cronometro");
        }
        //ObjecTp.SetActive(true);
    }
}
