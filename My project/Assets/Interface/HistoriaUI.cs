using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HistoriaUI : MonoBehaviour
{
    [Header("Configuração Texto")]
    [SerializeField][TextArea] private string[] ItemInfo;
    [SerializeField] private float TextoVelocidade = 0.01f;

    [Header("Elemento UI")]
    [SerializeField] private TextMeshProUGUI ItemInfoTexto;
    private int TextoAtual = 0;

    private int ProximoSampleSceneLoad2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AtivarTexto()
    {
        StartCoroutine(TextoAnimado());
    }

    IEnumerator TextoAnimado()
    {
        for (int i = 0; i < ItemInfo[TextoAtual].Length + 1; i++)
        {
            ItemInfoTexto.text = ItemInfo[TextoAtual].Substring(0, i);
            yield return new WaitForSeconds(TextoVelocidade);
        }
    }

    public void BotaoPular()
    {
        ProximoSampleSceneLoad2 = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(ProximoSampleSceneLoad2);
    }
}
