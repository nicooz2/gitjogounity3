using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPersonagem : MonoBehaviour
{
    
    private Rigidbody2D b_Rigidbody2D => GetComponent<Rigidbody2D>();
    public GameObject AvisoMaisUmPonto;


    
    
    // Update is called once per frame
    void Update()  
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item")
        {
            
            Destroy(collision.gameObject);
            Instantiate(AvisoMaisUmPonto, transform.position, Quaternion.identity);

        }

    }
    
}
