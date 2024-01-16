using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    // Purple belt is hard ;-;
    private Spawner spawner;
    public GameObject title;
    private Vector2 screenBounds;

    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.width, Camera.main.transform.position.z));
    }
    void Start()
    {
        spawner.active = false;
        title.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            spawner.active = true;
            title.SetActive(false);
        }
    }
    var nextBomb = GameObject.FindGameObjectsWithTag("Bomb");

        foreach (GameObject bombObject in nextBomb)
        {
        if(bombObject.transform.position.y < (-screenBounds.y) - 12)
        {
                         private void OnDestroy()
    {

    }
}
}
}
}
