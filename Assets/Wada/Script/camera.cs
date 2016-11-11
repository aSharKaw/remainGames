using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class camera : MonoBehaviour
{
    private int x = 50;

    void Start()
    {
       

       // transform.Rotate(new Vector3(0, 0, 0), Space.World);

    }

    void Update()
    {
        //上を押したら
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 10, -10), 10.0f);
            transform.Rotate(x, 0, 0);
        }
        //下を押したら
        if (Input.GetKeyDown((KeyCode.DownArrow)))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 3, -10), 10.0f);
            transform.Rotate(-x, 0, 0);
        }   
    }
}
