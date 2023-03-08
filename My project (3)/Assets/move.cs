using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.position = transform.position + (Vector3.left * 5f) * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position = transform.position + (Vector3.right * 5f) * Time.deltaTime;
        }
    }
}
