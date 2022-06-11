using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiScript : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject,0.1f);
        

    }

    
    void Update()
    {
        transform.Translate(Vector3.back);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("dusman"))
        {
            Destroy(gameObject);
           
        }
    }
}
