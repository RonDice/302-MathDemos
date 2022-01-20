using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitDemo : MonoBehaviour
{
    public Transform 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(!orbitCenter)
        float x = Mathf.Cos(Time.time);
        float z = Mathf.Sin(Time.time);

        transform.position = new Vector3(x, 0, z) + orbitCenter.position;

    }
}
