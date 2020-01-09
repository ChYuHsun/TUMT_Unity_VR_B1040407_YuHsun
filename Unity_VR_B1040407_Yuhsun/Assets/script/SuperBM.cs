using UnityEngine;

public class SuperBM : MonoBehaviour
{
    private Animator supermod;

    private void Start()
    {
        supermod = GetComponent<Animator>();
    }

    public void BottunSuperBM()
    {
        supermod.SetBool("superMod", true);
    }

}
