using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.InputSystem;

public class mouse2d : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    private void Update(){
        Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z =0f;
        transform.position = mouseWorldPosition;

    }
}
