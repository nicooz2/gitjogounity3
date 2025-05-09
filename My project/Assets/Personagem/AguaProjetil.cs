using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguaProjetil : MonoBehaviour
{
    public float VelocidadeAgua;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * VelocidadeAgua * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Elemento")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "ParedeLimite")
        {
            Destroy(gameObject);
        }
    }
}
