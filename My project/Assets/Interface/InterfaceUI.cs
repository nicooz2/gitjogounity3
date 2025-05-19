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

    public float TempoInicial;
    private float TempoRestante;
    [SerializeField] private TMP_Text TempoTexto;

    

    private int ProximoSampleSceneLoad;

    


    private void Awake()
    {
        instance = this;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        TempoRestante = TempoInicial;

        ProximoSampleSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    
    void Update()
    {

        if (TempoRestante > 0)
        {
            TempoRestante -= Time.deltaTime;
            TempoTexto.text = TempoRestante.ToString("0");
        }
        else
        {
            SceneManager.LoadScene(ProximoSampleSceneLoad);
            Time.timeScale = 1;
        }

        
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
