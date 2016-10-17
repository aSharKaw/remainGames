using UnityEngine;
using System.Collections;

public class DestryTime : MonoBehaviour
{
    [SerializeField]
    private float time_D;


    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, time_D);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
