using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    private bool EstaPausado;
    public GameObject JogoPauseUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (EstaPausado)
            {
                JogoResume();
            }
            else
            {
                JogoPause();
            }
        }
    }

    public void JogoPause()
    {
        Time.timeScale = 0;
        JogoPauseUI.SetActive(true);
        EstaPausado = true;
    }

    public void JogoResume()
    {
        Time.timeScale = 1;
        JogoPauseUI.SetActive(false);
        EstaPausado = false;
    }
}
