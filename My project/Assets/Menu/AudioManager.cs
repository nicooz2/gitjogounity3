using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource TrilhaSonoraFonte;
    [SerializeField] AudioSource EfeitoSonoroFonte;

    public AudioClip ColetarItem1Som;
    public AudioClip ContatoChaoSom;
    public AudioClip InicioFaseSom;
    public AudioClip GameOverSom;

    private void Start()
    {

    }

    public void AtivarEfeitoSonoro(AudioClip clip)
    {
        EfeitoSonoroFonte.PlayOneShot(clip);
    }
}
