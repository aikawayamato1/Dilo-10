using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Times : MonoBehaviour
{
    float times= 30f;
    public Text Timer;
    public GameObject Screen;

    // Update is called once per frame
    void Update()
    {

        times -= Time.deltaTime;
        Timer.text =  times.ToString("00");
        if(times <= 0f)
        {
            Time.timeScale = 0;
            Screen.SetActive(true);
        }
    }
}
