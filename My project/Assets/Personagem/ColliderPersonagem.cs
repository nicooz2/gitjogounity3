using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPersonagem : MonoBehaviour
{
    
   
    public GameObject AvisoMaisUmPonto;
    [SerializeField] private Rigidbody2D b2_rigidbody2D;

    

    
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

        if (collision.tag == "ÁguaRepresa")
        {
            b2_rigidbody2D.AddForce(new Vector3(40000f * Time.deltaTime, 30000f * Time.deltaTime, 0f));
        }

    }
    
}
