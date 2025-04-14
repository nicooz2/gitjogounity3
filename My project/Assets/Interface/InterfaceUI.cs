using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class InterfaceUI : MonoBehaviour
{

    public static InterfaceUI instance;

    [SerializeField] private GameObject BotaoTenteDeNovo;
    [SerializeField] private GameObject JogoGameOver;
    


    private void Awake()
    {
        instance = this;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbrirTelaGameOver()
    {
        Time.timeScale = 0;
        JogoGameOver.SetActive(true);
        BotaoTenteDeNovo.SetActive(true);
        
    }

    public void JogoRestart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
