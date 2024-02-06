using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoBoom : MonoBehaviour
{
    private ParticleSystem particleSmoke;
    // Start is called before the first frame update
    public void Awake()
    {
        particleSmoke = gameObject.GetComponentInChildren <ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!particleSmoke.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}
