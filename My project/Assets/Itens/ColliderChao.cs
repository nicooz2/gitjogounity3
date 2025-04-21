using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChao : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bombinha")
        {
            Destroy(collision.gameObject);
        }
    }
}
