using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class InterfaceUI4 : MonoBehaviour
{

    public static InterfaceUI4 instanceFase4;


    [SerializeField] private TextMeshProUGUI TempoTexto4;

    private void Awake()
    {
        instanceFase4 = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 1)
            TempoTexto4.text = Time.time.ToString("#,#");

        if (Time.time >= 10)
        {
            SceneManager.LoadScene(0);
        }
    }
}
