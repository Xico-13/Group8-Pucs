using System;
using UnityEngine;

public class TrocarDeTela : MonoBehaviour
{
    public GameObject telaInicial; // painel com �Pressione qualquer bot�o�
    public GameObject menuPrincipal; // painel com os bot�es

   

private bool jaPressionou = false;

    void Start()
    {
        // Garante que o menu est� escondido no in�cio
        if (menuPrincipal != null)
            menuPrincipal.SetActive(false);

        if (telaInicial != null)
            telaInicial.SetActive(true);
    }

    void Update()
    {
        if (!jaPressionou && Input.anyKeyDown)
        {
            jaPressionou = true;

            if (telaInicial != null)
                telaInicial.SetActive(false);

            if (menuPrincipal != null)
                menuPrincipal.SetActive(true);
        }
    }
}
