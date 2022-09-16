using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstracle : MonoBehaviour
{
    public GameObject boxToGenerate;
    
    void update() 
    {
        // When spacebar is hit
        if(Input.GetKeyDown(KeyCode.Space))
        {
            new GameObject("Object1");
            GameObject  newObject = new GameObject("newObject");
            newObject.AddComponent<CircleCollider2D>();
            // instantiate the box object
            //Instantiate(boxToGenerate);
        }
    }

}
// {
//     public GameObject  box;

//     // RaycastHit hit;
//     // void Start()
//     // {
//     //     Instantiate(gameObject, trans.position, Quaternion.identity);
//     // }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetMouseButtonDown(0)) {  
//             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
//             RaycastHit hit;  
//         if (Physics.Raycast(ray, out hit)) { 
//             for (var i = 0; i < 10; i++)
//             {
//                 Instantiate(box, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
//             }
//             // Instantiate(box);
//             Debug.Log(hit.transform.name);    
//         }          
//         }
//     }
// }