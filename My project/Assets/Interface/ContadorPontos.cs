using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContadorPontos : MonoBehaviour
{
    public int ContadorDePontos;
    public TMP_Text TextoMartelo;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextoMartelo.text = ContadorDePontos.ToString();
    }
}
