using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabricaDeCircle : MonoBehaviour
{
    float Espera = 0.3f;
    public GameObject Objeto;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Descida", Espera, Espera);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Descida()
    {
        Instantiate(Objeto, new Vector3(Random.Range(-20, 20), 14, 0), Quaternion.identity);
    }

}
