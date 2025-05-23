using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguaProjetil : MonoBehaviour
{
    public float VelocidadeAgua;
    public GameObject AvisoMaisUmPonto2;

    AudioManager audioManager4;


    private void Awake()
    {

        audioManager4 = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
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
            Instantiate(AvisoMaisUmPonto2, transform.position, Quaternion.identity);
            audioManager4.AtivarEfeitoSonoro(audioManager4.ColetarItem1Som);
        }

        if (collision.gameObject.tag == "ParedeLimite")
        {
            Destroy(gameObject);
        }
    }
}
