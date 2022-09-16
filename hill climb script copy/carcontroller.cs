using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class carcontroller : MonoBehaviour
{
    private float _fuel = 0.5f;

    public float fuelconsumption =0.005f;

    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public UnityEngine.UI.Image image;
    public float speed = 5f;
    public float carTorque = 2f;
    private float movement;
    
    public float Fuel {
        get {
            return _fuel;
        }
        set {
            _fuel = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_fuel>0) {
            movement = Input.GetAxis("Horizontal");
            image.fillAmount = _fuel;
        }
    }

    private void FixedUpdate()
    {
        if(_fuel>0)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carRigidbody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
            _fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
        }
    }
}
