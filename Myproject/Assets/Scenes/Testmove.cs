using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using TitaniumAS.Opc.Client.Interop;
using System;

public class Testmove : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;
    public GameObject Test;

    // Start is called before the first frame update
    void Start()
    {
        TitaniumAS.Opc.Client.Bootstrap.Initialize();
        Uri uri = new Uri ("opc.tcp://DESKTOP-IKC9PUE:4840/");
    }

    // Update is called once per frame
    void Update()
    {
        Test.transform.position = new Vector3(X, Y, Z);
    }
}
