using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class OrbitDemo : MonoBehaviour
{
    public Transform orbitCenter;

    public float radius = 1000;
    public int res = 32;

    private LineRenderer path;

    // Start is called before the first frame update
    void Start()
    {
        path = GetComponent<LineRenderer>();
        UpdateOrbitPath();
    }

    
    void Update()
    {

        if (!orbitCenter) return;
        float x = Mathf.Cos(Time.time);
        float z = Mathf.Sin(Time.time);

        transform.position = new Vector3(x, 0, z) + orbitCenter.position;

        if (orbitCenter.hasChanged) UpdateOrbitPath();

    }

    void UpdateOrbitPath()
    {
        if (!orbitCenter) return;

        float radsPerCircle = 2 * Mathf.PI;

        int res = 32;

        Vector3[] pts = new Vector3[res];


        for (int i = 0; i < pts.Length; i++) 
        { 

         float x = Mathf.Cos(i * radsPerCircle/res);
         float z = Mathf.Sin(i * radsPerCircle/res);

         Vector3 pt = new Vector3(x, 0, z) + orbitCenter.position;
            pts[i] = pt;

        }

        path.positionCount = res;
        path.SetPositions(pts);
    }
}
