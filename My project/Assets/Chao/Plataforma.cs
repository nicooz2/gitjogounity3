using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public Transform PontoA;
    public Transform PontoB;
    public float MoviVelocidade = 10f;

    private Vector3 ProximoEspaco;

    // Start is called before the first frame update
    void Start()
    {
        ProximoEspaco = PontoB.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, ProximoEspaco, MoviVelocidade * Time.deltaTime);

        if (transform.position == ProximoEspaco)
        {
            ProximoEspaco = (ProximoEspaco == PontoA.position) ? PontoB.position : PontoA.position;
        }
    }
}
