using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cubecolor : MonoBehaviour
{
    public byte A;
    public byte X;
    public byte C;
    public Text text;
    public int g;

  


    void Update()
    {
        text.text = g.ToString();
    }
    public void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Floor")
        {
            g++;
            A = (byte)Random.Range(0, 255);
            X = (byte)Random.Range(0, 255);
            C = (byte)Random.Range(0, 255);
            GetComponent<Renderer>().material.color = new Color32(A, X, C, 255);
        }
        else
        {
            A = (byte)Random.Range(200, 255);
            X = (byte)Random.Range(200, 255);
            C = (byte)Random.Range(200, 255);
            GetComponent<Renderer>().material.color = new Color32(A, X, C, 255);
        }
    }
}
