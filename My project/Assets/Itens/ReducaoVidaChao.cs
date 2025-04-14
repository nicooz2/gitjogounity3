using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducaoVidaChao : MonoBehaviour
{
    public int SubtracaoVida = 1;
    private VidaChao VidaDoChao;

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
        if (collision.gameObject.tag == "Chao")
        {

            Destroy(gameObject);

            if (VidaDoChao == null)
            {

                VidaDoChao = collision.gameObject.GetComponent<VidaChao>();
                
            }
            VidaDoChao.ChaoComItem(SubtracaoVida);
        }
    }



}