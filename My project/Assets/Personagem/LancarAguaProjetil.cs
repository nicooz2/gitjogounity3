using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancarAguaProjetil : MonoBehaviour
{
    public GameObject AguaProjetilsprite;
    private bool PodeAgua =  true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && PodeAgua) // mouse esquerdo m1
        {
            Instantiate(AguaProjetilsprite, transform.position, Quaternion.identity);
            StartCoroutine(IntervaloAgua());
        }
    }

    IEnumerator IntervaloAgua()
    {
        PodeAgua = false;
        yield return new WaitForSeconds(0.7f);
        PodeAgua = true;
    }
}
