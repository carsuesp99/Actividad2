using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string helloWorld = "Hello World!";
    // Start is called before the first frame update
    void Start()
    {
        print(helloWorld);
    }

    // Update is called once per frame
    void Update()
    {
        print(helloWorld);
    }
}
