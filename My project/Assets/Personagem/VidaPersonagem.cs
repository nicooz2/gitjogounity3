using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPersonagem : MonoBehaviour
{
    public int vidas = 3;
    public Image[] VidaImagem;
    public GameObject AvisoMenosUmPonto;
    private SpriteRenderer SpriteRenderizador;

    AudioManager audioManager8;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderizador = GetComponent<SpriteRenderer>();
        audioManager8 = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
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
            StartCoroutine(Flash());
            audioManager8.AtivarEfeitoSonoro(audioManager8.ColliderPersonagemSom);
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
            Instantiate(AvisoMenosUmPonto, transform.position, Quaternion.identity);
            StartCoroutine(Flash());
            audioManager8.AtivarEfeitoSonoro(audioManager8.ColliderPersonagemFase2Som);
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
            Instantiate(AvisoMenosUmPonto, transform.position, Quaternion.identity);
            StartCoroutine(Flash());
            audioManager8.AtivarEfeitoSonoro(audioManager8.ColliderPersonagemFase4Som);
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
        if (collision.tag == "ÁguaRepresa")
        {
            Instantiate(AvisoMenosUmPonto, transform.position, Quaternion.identity);
            StartCoroutine(Flash());
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

    private IEnumerator Flash()
    {
        SpriteRenderizador.color = Color.gray;
        yield return new WaitForSeconds(0.2f);
        SpriteRenderizador.color = Color.white;
    }
}
