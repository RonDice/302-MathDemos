using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class OrbitDemo : MonoBehaviour
{

    public float timeMultiplier = 1;
    public float timeOffset = 0;

    public GameObject rotateCenter;
    public Transform orbitCenter;

    public float radius = 10;
    public int res = 128;
        

    private LineRenderer path;

    // Start is called before the first frame update
    void Start()
    {
        path = GetComponent<LineRenderer>();

        path.loop = true;
        path.useWorldSpace = true;

        UpdateOrbitPath();
    }

    
    void Update()
    {
        //Orbit Path
        if (!orbitCenter) return;
        float x = radius * Mathf.Cos(Time.time * timeMultiplier + timeOffset  );
        float z = radius * Mathf.Sin(Time.time * timeMultiplier + timeOffset  );

        transform.position = new Vector3(x,0,z) + orbitCenter.position;

        if (orbitCenter.hasChanged) UpdateOrbitPath();


        //Planetary Rotation
        transform.RotateAround(rotateCenter.transform.position, Vector3.up, 20 * Time.deltaTime);



    }

    void UpdateOrbitPath()
    {
        if (!orbitCenter) return;

        float radsPerCircle = 2 * Mathf.PI;

        int res = 32;

        Vector3[] pts = new Vector3[res];


        for (int i = 0; i < pts.Length; i++) 
        { 

         float x = radius *Mathf.Cos(i * radsPerCircle/res);
         float z = radius *Mathf.Sin(i * radsPerCircle/res);

         Vector3 pt = new Vector3(x, 0, z) + orbitCenter.position;
            pts[i] = pt;

        }

        path.positionCount = res;
        path.SetPositions(pts);
    }
}
