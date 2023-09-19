using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spherecolor : MonoBehaviour
{
    public byte R;
    public byte G;
    public byte B;
    public GameObject Sphere;

    // Update is called once per frame
   
    public void ChangeSphere()
    {
        R = (byte)Random.Range(0, 255);
        G = (byte)Random.Range(0, 255);
        B = (byte)Random.Range(0, 255);
        Sphere.GetComponent<Renderer>().material.color = new Color32(R, G, B, 255);
    }
}
