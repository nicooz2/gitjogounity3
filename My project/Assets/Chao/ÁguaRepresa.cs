using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ÁguaRepresa : MonoBehaviour
{
    public float VelocidadeÁguaRepresa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * VelocidadeÁguaRepresa * Time.deltaTime);
    }
}
