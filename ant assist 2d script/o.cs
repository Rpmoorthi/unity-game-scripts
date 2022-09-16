using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o : MonoBehaviour
{
    // public float waitTime = 2.0f;
    // float timer;
    [SerializeField] GameObject dotPrefab;

    void Start()
    {
        // StartCoroutine(SelfDestruct());
        // StartCoroutine(time());
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);  
            GameObject g = Instantiate(dotPrefab, (Vector2)spawnPosition,Quaternion.identity);
           StartCoroutine(SelfDestruct(g));              

     }
    }

    IEnumerator SelfDestruct(GameObject drops)
    {
    yield return new WaitForSeconds(2f);
    Destroy(drops);
    }


    
} 
