using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Nome da cena do jogo principal (coloque o nome exato da cena que quer carregar)
    public string SampleSceneFase1 = "CenaJogo";

    public void IniciarJogo()
    {
        SceneManager.LoadScene(SampleSceneFase1);
    }

    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
