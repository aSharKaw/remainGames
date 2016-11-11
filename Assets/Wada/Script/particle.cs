using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class particle : MonoBehaviour
{

    private ParticleSystem mParticle;//パーティクル

    // Use this for initialization
    void Start()
    {

        mParticle = GetComponent<ParticleSystem>();
        mParticle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameTime.tFlag)
        {
            StartCoroutine("isParticle");
        }
        
    }

    IEnumerator isParticle()
    {
        mParticle.Stop();
        yield return new WaitForSeconds(28.0f);
        mParticle.Play();
    }
}
