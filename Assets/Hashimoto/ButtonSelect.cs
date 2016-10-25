using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonSelect : MonoBehaviour
{

	void Start ()
    {
	
	}

    void Update ()
    {
        GetComponent<Button>().Select();
	}

    
}
