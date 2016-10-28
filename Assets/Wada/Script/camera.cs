using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{
   
    int x = 50;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
       
       if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 10, -10), 10.0f);
            transform.Rotate(x, 0, 0);

        }

       if(Input.GetKeyDown((KeyCode.DownArrow)))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 3, -10), 10.0f);
            transform.Rotate(-x, 0, 0);

        }

    }
}
