using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaChao : MonoBehaviour
{
    
    public int Vida;
    public int VidaCheia = 10;

    // Start is called before the first frame update
    void Start()
    {
        Vida = VidaCheia;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChaoComItem (int quantidade)
    {
        Vida -= quantidade;
    }
}
