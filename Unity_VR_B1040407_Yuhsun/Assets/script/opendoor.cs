using UnityEngine;

public class opendoor : MonoBehaviour
{
    private Animator open;

    private void Start()
    {
        open = GetComponent<Animator>();
    }

    public void Opendoor()
    {
        open.SetBool("dooropen", true);
    }
}
 