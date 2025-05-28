using UnityEngine;
using UnityEngine.UI;

public class ColorBlindToggle : MonoBehaviour
{
    public GameObject colorBlindOptionsPanel; // Arrasta aqui o painel das opções

    private bool isPanelActive = false;

    void Start()
    {
        if (colorBlindOptionsPanel != null)
            colorBlindOptionsPanel.SetActive(false); // garante que está escondido no início
    }

    public void ToggleColorBlindOptions()
    {
        if (colorBlindOptionsPanel == null) return;

        isPanelActive = !isPanelActive;
        colorBlindOptionsPanel.SetActive(isPanelActive);
        Debug.Log("Painel Color Blind está agora " + (isPanelActive ? "ativado" : "desativado"));
    }
}