using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VidaDoChefao : MonoBehaviour
{
    public float VidaMaxima = 100;
    public float VidaChefao = 100;

    private SpriteRenderer SpriteRenderizadorDano;


    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderizadorDano = GetComponent<SpriteRenderer>();
        VidaChefao = VidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        if (VidaChefao <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Personagem")
        {

            VidaChefao -= 10;
            StartCoroutine(ChefaoFlash());
        }
    }

    private IEnumerator ChefaoFlash()
    {
        SpriteRenderizadorDano.color = Color.gray;
        yield return new WaitForSeconds(0.2f);
        SpriteRenderizadorDano.color = Color.white;

    }
}
