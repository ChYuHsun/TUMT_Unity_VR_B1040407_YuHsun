using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Point : MonoBehaviour {

    public Text Point_UI;
    public int Point_int = 0;
    public GameObject Time;

    // Use this for initialization
    void Start ()
    {
        Time = GameObject.Find("Timee");
	}
	
	// Update is called once per frame
	void Update ()
    {
        Point_UI.text = Point_int.ToString();
        
        if (Time.GetComponent<Time>().Time_int == 60)
        {
            Point_int = 0;           
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            Point_int += Random.Range(2,3);
            
        }
    }
}
