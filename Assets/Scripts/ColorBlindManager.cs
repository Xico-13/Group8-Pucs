using UnityEngine;
using UnityEngine.UI;

public class ColorBlindToggle : MonoBehaviour
{
    public GameObject colorBlindOptionsPanel; // Arrasta aqui o painel das op��es

    private bool isPanelActive = false;

    void Start()
    {
        if (colorBlindOptionsPanel != null)
            colorBlindOptionsPanel.SetActive(false); // garante que est� escondido no in�cio
    }

    public void ToggleColorBlindOptions()
    {
        if (colorBlindOptionsPanel == null) return;

        isPanelActive = !isPanelActive;
        colorBlindOptionsPanel.SetActive(isPanelActive);
        Debug.Log("Painel Color Blind est� agora " + (isPanelActive ? "ativado" : "desativado"));
    }
}