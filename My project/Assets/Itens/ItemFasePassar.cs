using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemFasePassar : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OntriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Personagem")
        {
            SceneManager.LoadScene(7);
        }
    }
}
