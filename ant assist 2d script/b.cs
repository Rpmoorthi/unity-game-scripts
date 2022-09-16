using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class b : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 100;
    // [SerializeField] GameObject child1, child2, child3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(20* Time.deltaTime * speed, 20* Time.deltaTime*speed));

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 18.5f)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if(transform.position.x <= -18.5f)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);     
        }
    }
    // private void OnCollisionEnter2D(Collision2D collision)
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.tag == "ant")
    //     {
    //         child1.SetActive(false);
    //         child2.SetActive(false);
    //         child3.SetActive(false);
    //     }}

}
