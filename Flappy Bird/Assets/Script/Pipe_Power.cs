using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Power : MonoBehaviour
{
    public float maxTime = 1;
    private float timer= 0;
    public GameObject pipe;
    public float height;

    private void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }
    void Update()
    {
        if (timer>maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height));
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}