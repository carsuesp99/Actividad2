using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField]
    private Vector3 axes;
    public float scaleUnits;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        axes = CapsuleController.ClampVector3(axes);

        transform.localScale += axes * (scaleUnits * Time.deltaTime);
    }
}
