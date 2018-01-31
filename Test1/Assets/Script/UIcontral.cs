using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontral : MonoBehaviour {

	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(1);
        }
	}
    public void Click()
    {
        Debug.LogError("Button");
    }
}
