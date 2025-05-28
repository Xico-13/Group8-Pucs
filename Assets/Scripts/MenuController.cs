using System;
using UnityEngine;

public class TrocarDeTela : MonoBehaviour
{
    public GameObject telaInicial; // painel com “Pressione qualquer botão”
    public GameObject menuPrincipal; // painel com os botões

   

private bool jaPressionou = false;

    void Start()
    {
        // Garante que o menu está escondido no início
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
