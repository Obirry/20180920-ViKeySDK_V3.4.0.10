using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices; // DllImport
using ViKeySample;


public class MainWnd : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Program.ViKeyTest();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, 30 * Time.deltaTime);
    }
}
