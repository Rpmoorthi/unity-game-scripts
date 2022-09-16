using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target;
    private Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        Offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + Offset;
    }
} 
