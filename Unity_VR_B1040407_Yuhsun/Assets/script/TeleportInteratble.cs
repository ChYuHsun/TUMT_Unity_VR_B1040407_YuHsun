
using UnityEngine;

public class TeleportInteratble : MonoBehaviour
{
    public Animator animatorControl;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "HeadCollider" && GameManager.takeballkey)
        {
            animatorControl.SetBool("takeball", true);
        }
    }
} 
