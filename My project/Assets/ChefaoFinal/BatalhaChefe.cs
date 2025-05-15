using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatalhaChefe : MonoBehaviour
{
    public Transform Personagem;
    public float CorridaVelocidade = 2f;
    public float ForçaPulo = 2f;
    public LayerMask chaoLayer2;

    private Rigidbody2D rb;
    private bool EstaNoChao;
    private bool PularAgora;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Está no chão
        EstaNoChao = Physics2D.Raycast(transform.position, Vector2.down, 1f, chaoLayer2);

        // Movimento do cl34ner
        float direction = Mathf.Sign(Personagem.position.x - transform.position.x);

        // Detectar movimento de cima
        bool PersonagemEstaAcima = Physics2D.Raycast(transform.position, Vector2.up, 3f, 1 << Personagem.gameObject.layer);

        if (EstaNoChao)
        {
            // Ir atrás do Personagem
            rb.velocity = new Vector2(direction * CorridaVelocidade, rb.velocity.y);

            // Se está no chão
            RaycastHit2D ChaoAFrente = Physics2D.Raycast(transform.position, new Vector2(direction, 0), 2f, chaoLayer2);

            // Se tem espaço
            RaycastHit2D EspacoAFrente = Physics2D.Raycast(transform.position + new Vector3(direction, 0, 0), Vector2.down, 2f, chaoLayer2);

            // Se plataforma está acima
            RaycastHit2D PlataformaAcima = Physics2D.Raycast(transform.position, Vector2.up, 3f, chaoLayer2);

            if (!ChaoAFrente.collider && !EspacoAFrente.collider)
            {
                PularAgora = true;
            }
            else if (PersonagemEstaAcima && PlataformaAcima.collider)
            {
                PularAgora = true;
            }
        }
 
    }

    private void FixedUpdate()
    {
        if (EstaNoChao && PularAgora)
        {
            PularAgora = false;
            Vector2 direction = (Personagem.position - transform.position).normalized;

            Vector2 DirecaoPulo = direction * ForçaPulo;

            rb.AddForce(new Vector2(DirecaoPulo.x, ForçaPulo), ForceMode2D.Impulse);
        }
    }
}
