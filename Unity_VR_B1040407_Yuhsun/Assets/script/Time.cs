using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public int Time_int = 60;
    public Text Time_UI;
    public GameObject openBM;
    internal static readonly int deltaTime;

    private void Start()
    {
        openBM = GameObject.Find("openBM");
    }

    void timer()
    {
        Time_int -= 1;
        Time_UI.text = Time_int + "";
        if(Time_int == 0)
        {
            openBM.GetComponent<StartBM>().GAME = false;
            Time_UI.text = "TIME UP!";
            CancelInvoke("timer");
            Time_int = 60;
        }
    }

    public void StartTime()
    {
        InvokeRepeating("timer", 1, 1);
    }
}
