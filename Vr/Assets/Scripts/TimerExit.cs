using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TimerExit : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    public TextMeshProUGUI WinText;
    public float matchTimer;

     public static TimerExit Instance;

    public bool hasEnded = false;
    public bool StarTime = false;
    // Start is called before the first frame update
    // Update is called once per frame
    private void Awake()
    {
        Instance = this;

        Timer.text = "";
    }
    void Update()
    {
       
        if (StarTime && !hasEnded)
        {
            matchTimer -= Time.deltaTime;
            UpdateMatchTimeDisplay(Mathf.Clamp(matchTimer, 0, 99999));
            if (matchTimer <=0)
            {
                SceneManager.LoadScene(1);
                hasEnded = true;
                Debug.Log("se acabo");
            }
        }
        if (hasEnded)
        {
            Debug.Log("nada");
        }
    }
    
    public void UpdateMatchTimeDisplay(float time)
    {
        int formatedTime = (int)Math.Ceiling(time);

        // Formatear a minutos y segundos
        int minutos = formatedTime / 60; // Obtener los minutos
        formatedTime %= 60; // Obtener los segundos restantes
        string mmssTime = minutos.ToString("0") + ":" + formatedTime.ToString("00");

        Timer.text = mmssTime;
    }
    public void StarToTime()
    {
        StarTime = true;
    }
    public void Win()
    {
        StarTime = false;

        WinText.text = "Lograste escapar del hospital " +
            "";
    }
}
