using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelcollect : MonoBehaviour
{
    public carcontroller carController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "fuel")
        {
            Destroy(collision.gameObject);
            carController.Fuel = carController.Fuel + 0.25f;

        } 
    }
}
