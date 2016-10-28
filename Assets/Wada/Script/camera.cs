using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{
   
    private int x = 50;
    
    void Start()
    {

    }

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
