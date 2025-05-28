using UnityEngine;
using System.Collections;
using System;

public class TransicaoMenu : MonoBehaviour
{
    public CanvasGroup telaInicial;
    public CanvasGroup menuPrincipal;
    public float duracaoFade = 2f; // tempo da transição

private bool iniciouTransicao = false;

    void Start()
    {
        telaInicial.alpha = 1f;
        telaInicial.interactable = true;
        telaInicial.blocksRaycasts = true;

        menuPrincipal.alpha = 0f;
        menuPrincipal.interactable = false;
        menuPrincipal.blocksRaycasts = false;
    }

    void Update()
    {
        if (!iniciouTransicao && Input.anyKeyDown)
        {
            iniciouTransicao = true;
            StartCoroutine(FazerTransicao());
        }
    }

    IEnumerator FazerTransicao()
    {
        float tempo = 0f;

        while (tempo < duracaoFade)
        {
            tempo += Time.deltaTime;
            float t = Mathf.Clamp01(tempo / duracaoFade);
            float suavizado = Mathf.SmoothStep(0f, 1f, t); // transição mais suave

            telaInicial.alpha = Mathf.Lerp(1f, 0f, suavizado);
            menuPrincipal.alpha = Mathf.Lerp(0f, 1f, suavizado);

            yield return null;
        }

        // Garante os estados finais
        telaInicial.alpha = 0f;
        telaInicial.interactable = false;
        telaInicial.blocksRaycasts = false;

        menuPrincipal.alpha = 1f;
        menuPrincipal.interactable = true;
        menuPrincipal.blocksRaycasts = true;
    }
}