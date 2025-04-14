using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaChao : MonoBehaviour
{
    
    public int Vida;
    public int VidaCheia = 10;
    public Slider BarraDeVida;
    public Gradient CorGradiente;
    public Image CorBarra;

    // Start is called before the first frame update
    void Start()
    {
        Vida = VidaCheia;
        BarraDeVida.maxValue = VidaCheia;
        BarraDeVida.value = Vida;

        CorBarra.color = CorGradiente.Evaluate(1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChaoComItem (int quantidade)
    {
        Vida -= quantidade;
        BarraDeVida.value = Vida;

        CorBarra.color = CorGradiente.Evaluate(BarraDeVida.normalizedValue);

        if (Vida <= 0)
        {
            InterfaceUI.instance.AbrirTelaGameOver(); // abrindo a tela de game over
        }
    }
}
