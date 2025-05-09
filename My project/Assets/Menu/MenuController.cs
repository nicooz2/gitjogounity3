using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Nome da cena do jogo principal coloque o nome exato da cena que quer carregar

    public void IniciarJogo()
    {
        SceneManager.LoadScene(1);
    }

    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
