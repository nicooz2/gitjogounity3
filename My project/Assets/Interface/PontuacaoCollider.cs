using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontuacaoCollider : MonoBehaviour
{
    public ContadorPontos ContadorPontuacao;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item")
        {
            ContadorPontuacao.ContadorDePontos++;
        }
    }

}
