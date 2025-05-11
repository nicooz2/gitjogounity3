using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoUI : MonoBehaviour
{
    public float DestruirPonto = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestruirPonto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
