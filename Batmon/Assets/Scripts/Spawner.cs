using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Collectable;
    public float height;
    public float timetolive = 5;
    public GameObject topboundary;
    public GameObject botboundary;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newCollectable = Instantiate(Collectable);
        float topy= topboundary.transform.position.y;
        float boty= botboundary.transform.position.y;
        if(height > topy)
        {
            height = topy;
        }
        else if (height < boty)
        {
            height = boty;
        }
        newCollectable.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime) 
        {
            GameObject newCollectable = Instantiate(Collectable);
            float topy= topboundary.transform.position.y;
            float boty= botboundary.transform.position.y;
            if(height > topy)
            {
                height = topy;
            }
            else if (height < boty)
            {
                height = boty;
            }
            newCollectable.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);

            Destroy(newCollectable, timetolive);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}