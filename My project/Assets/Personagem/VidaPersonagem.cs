using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPersonagem : MonoBehaviour
{
    public int vidas = 3;
    public Image[] VidaImagem;

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
    }
}
