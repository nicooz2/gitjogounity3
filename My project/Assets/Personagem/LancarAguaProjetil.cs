using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancarAguaProjetil : MonoBehaviour
{
    public GameObject AguaProjetilsprite;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // mouse esquerdo m1
        {
            Instantiate(AguaProjetilsprite, transform.position, Quaternion.identity);
        }
    }
}
