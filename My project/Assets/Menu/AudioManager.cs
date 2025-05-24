using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource TrilhaSonoraFonte;
    [SerializeField] AudioSource EfeitoSonoroFonte;

    public AudioClip PuloSom;
    public AudioClip TrilhaSonoraSom;
    public AudioClip ColetarItem1Som;
    public AudioClip ContatoChaoSom;
    public AudioClip InicioFaseSom;
    public AudioClip GameOverSom;
    public AudioClip ColliderPersonagemSom;
    public AudioClip ColliderPersonagemFase2Som;
    public AudioClip ColliderPersonagemFase4Som;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        TrilhaSonoraFonte.clip = TrilhaSonoraSom;
        TrilhaSonoraFonte.Play();
    }

    public void AtivarEfeitoSonoro(AudioClip clip)
    {
        EfeitoSonoroFonte.PlayOneShot(clip);
    }
}
