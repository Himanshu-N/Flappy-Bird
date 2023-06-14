using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject PrefabPipe;
    float timing = 0;

    // Update is called once per frame
    void Update()
    {
        timing += Time.deltaTime;
        if (timing > 1.1) 
        {
            Vector2 randomPos = new Vector2(transform.position.x,Random.Range(0.76f,-0.36f));
            GameObject newPipe = Instantiate(PrefabPipe, randomPos, Quaternion.identity);
            timing = 0;
            Destroy(newPipe,7);
        }
    }
}
