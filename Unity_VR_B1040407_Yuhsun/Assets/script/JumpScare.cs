
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public Animator ScareControl;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider")
        {
            ScareControl.SetBool("jumpscare", true);
        }
    }
}
