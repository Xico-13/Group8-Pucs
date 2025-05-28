using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menuPrincipalPanel;
    public GameObject startGamePanel;
    public GameObject optionsPanel;
    public GameObject colorBlindPanel; // Painel com os botões de daltonismo

    private bool isColorBlindPanelOpen = false;

    void Start()
    {
        Debug.Log("MenuManager iniciado");

        menuPrincipalPanel.SetActive(true);
        startGamePanel.SetActive(false);
        optionsPanel.SetActive(false);

        if (colorBlindPanel != null)
        {
            colorBlindPanel.SetActive(false);
            isColorBlindPanelOpen = false;
        }
    }

    public void ShowStartGameMenu()
    {
        Debug.Log("ShowStartGameMenu chamado");

        menuPrincipalPanel.SetActive(false);
        startGamePanel.SetActive(true);
        optionsPanel.SetActive(false);

        FecharPainelColorBlind(); // Garante que o painel de daltonismo fecha
    }

    public void ShowOptionsMenu()
    {
        Debug.Log("ShowOptionsMenu chamado");

        menuPrincipalPanel.SetActive(false);
        startGamePanel.SetActive(false);
        optionsPanel.SetActive(true);

        FecharPainelColorBlind(); // Fecha ao entrar no menu de opções
    }

    public void BackToMainMenu()
    {
        Debug.Log("BackToMainMenu chamado");

        menuPrincipalPanel.SetActive(true);
        startGamePanel.SetActive(false);
        optionsPanel.SetActive(false);

        FecharPainelColorBlind(); // Fecha para garantir que não fica visível
    }

    public void ToggleColorBlindPanel()
    {
        if (colorBlindPanel == null) return;

        // Alterna o estado: se estiver visível, esconde; se estiver escondido, mostra
        isColorBlindPanelOpen = !isColorBlindPanelOpen;
        colorBlindPanel.SetActive(isColorBlindPanelOpen);

        Debug.Log("Color Blind Panel ativo: " + isColorBlindPanelOpen);
    }

    private void FecharPainelColorBlind()
    {
        if (colorBlindPanel != null)
        {
            colorBlindPanel.SetActive(false);
            isColorBlindPanelOpen = false;
        }
    }

    public void StartNewGame()
    {
        Debug.Log("A carregar nova cena: Game");
        SceneManager.LoadScene("Game");
    }
}
