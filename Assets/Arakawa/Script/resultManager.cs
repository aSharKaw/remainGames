using UnityEngine;
using System.Collections;

public class resultManager : MonoBehaviour {

    [SerializeField]
    private Vector2 position = Vector2.zero;
    [SerializeField]
    private Vector2 size = Vector2.zero;

    private string PlayerName = "hoge";

    void OnGUI()
    {
        PlayerName = GUI.TextField(new Rect(position, size), PlayerName, 5);
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	}
}
