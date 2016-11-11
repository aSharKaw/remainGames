using UnityEngine;
using System.Collections;

public class gameLight : MonoBehaviour
{

   
    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //太陽が移動
        if (gameTime.tFlag)
        {
            transform.rotation = transform.rotation * (Quaternion.Euler(Time.deltaTime * 5, 0, 0));
        }

        
    }
}
