using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartBM : MonoBehaviour
{
    private Animator up;
    public GameObject TT;
    public bool GAME = false;

    private void Start()
    {
        up = GetComponent<Animator>();
    }
    private void Update()
    {
        if(GAME == false)
        {
            up.SetBool("timeout", true);
            up.SetBool("StartBM", false);
            up.SetBool("notmove", false);
        }

        
    }

    public void BottunStartBM()
    {
        if (TT.GetComponent<Time>().Time_int == 60 && GAME == false)
        {
            GAME = true;
            up.SetBool("timeout", false);
            up.SetBool("StartBM", true);
            up.SetBool("notmove", false);
        }

    }


}
