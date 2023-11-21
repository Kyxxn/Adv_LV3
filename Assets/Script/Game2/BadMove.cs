using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadMove : MonoBehaviour
{
    public float speed;
    private float rnd;
    private bool dir;
    void Start()
    {
        speed = Random.Range(8, 20);
        rnd = Random.Range(0, 10);
        dir = rnd > 5 ? true : false;
    }

    void Update()
    {
        Vector3 flip = Vector3.zero;

        if (dir)
        {
            flip = Vector3.left;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            flip = Vector3.right;
            transform.localScale = new Vector3(1, 1, 1);
        }

        transform.position += flip * speed * Time.deltaTime;
    }

    private void OnMouseDown()
    {
        Score.score--;
    }
}
