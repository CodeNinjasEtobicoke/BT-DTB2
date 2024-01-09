using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    // Purple belt is hard (;-;)
    private Spawner spawner;
    private void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
    }
    void Start()
    {
        spawner.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            spawner.active = false;
    }
}
