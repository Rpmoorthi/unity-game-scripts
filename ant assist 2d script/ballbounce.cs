using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballbounce : MonoBehaviour
{
    // [SerializeField] GameObject child1, child2, child3;
    Rigidbody2D rb;
    private float dir;
    Vector3 LastVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dir = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        LastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = LastVelocity.magnitude;
        var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity =direction *Mathf.Max(speed, 0f);
    //     if (collision.tag == "ant")
    //     {
    //         child1.SetActive(false);
    //         child2.SetActive(false);
    //         child3.SetActive(false);
    //     }
    }

}
