using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPersonagem : MonoBehaviour
{
    public float SeguirVelocidade = 2f;
    public float YBorda = 1f;
    public Transform PersonagemCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NovaPosicao02 = new Vector3(PersonagemCamera.position.x, PersonagemCamera.position.y + YBorda, -10f);
        transform.position = Vector3.Slerp(transform.position, NovaPosicao02, SeguirVelocidade * Time.deltaTime);
    }
}
