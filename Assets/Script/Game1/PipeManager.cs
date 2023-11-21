using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff = 2.8f;
    private float timer = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject Pipe = Instantiate(pipe);
            Pipe.transform.position = new Vector3(transform.position.x, Random.Range(-1.7f, 4.5f), 0);
            timer = 0;
            Destroy(Pipe, 15.0f);
        }
    }
}
