using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaPesar : MonoBehaviour
{
    public float speed;
    Vector2 PosicaoOriginal;

    public bool Ativar;

    // Start is called before the first frame update
    void Start()
    {
        PosicaoOriginal = transform.position;
        Ativar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Ativar)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, PosicaoOriginal, speed * Time.deltaTime);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Personagem")
        {
            Ativar = true;
            other.transform.SetParent(this.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
            Ativar = false;
            other.transform.SetParent(null);
        
    }
}
