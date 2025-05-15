using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDoChefao : MonoBehaviour
{
    public float VidaMaxima = 100;
    public float VidaChefao = 100;

    // Start is called before the first frame update
    void Start()
    {
        VidaChefao = VidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Personagem")
        {
            VidaChefao -= 10;
        }
    }

}
