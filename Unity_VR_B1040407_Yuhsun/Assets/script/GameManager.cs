using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool takeballkey;

    public void Pickup()
    {

    }

    public void Detach(GameObject obj)
    {
        takeballkey = true;
        Destroy(obj);
    }
    public void Held()
    {

    }
}
