using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPersonagem : MonoBehaviour
{
    public int vidas = 3;
    public Image[] VidaImagem;
    public GameObject AvisoMenosUmPonto;

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
        if (collision.tag == "Bombinha")
        {
            Destroy(collision.gameObject);
            Instantiate(AvisoMenosUmPonto, transform.position, Quaternion.identity);
            vidas -= 1;
            for (int i = 0; i < VidaImagem.Length; i++)
            {
                if (i < vidas)
                {
                    VidaImagem[i].enabled = true;
                }
                else
                {
                    VidaImagem[i].enabled = false;
                }
            }
            if (vidas <= 0)
            {
               InterfaceUI.instance.AbrirTelaGameOver();
            }
        }
        if (collision.tag == "Elemento")
        {
            Destroy(collision.gameObject);
            vidas -= 1;
            for (int i2 = 0; i2 < VidaImagem.Length; i2++)
            {
                if (i2 < vidas)
                {
                    VidaImagem[i2].enabled = true;
                }
                else
                {
                    VidaImagem[i2].enabled = false;
                }

            }
            if (vidas <= 0)
            {
                InterfaceUI.instance.AbrirTelaGameOver();
            }
        }
        if (collision.tag == "Objeto")
        {
            Destroy(collision.gameObject);
            vidas -= 1;
            for (int i2 = 0; i2 < VidaImagem.Length; i2++)
            {
                if (i2 < vidas)
                {
                    VidaImagem[i2].enabled = true;
                }
                else
                {
                    VidaImagem[i2].enabled = false;
                }

            }
            if (vidas <= 0)
            {
                InterfaceUI.instance.AbrirTelaGameOver();
            }
        }
    }
}
