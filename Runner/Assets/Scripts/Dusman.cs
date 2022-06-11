using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dusman : MonoBehaviour
{
    NavMeshAgent nav;
    public GameObject Karakter;
     
     void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        nav.SetDestination(Karakter.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("mermi"))
        {
            gameObject.SetActive(false);
            GameManager.sayý++;

            
        }

    }
}
