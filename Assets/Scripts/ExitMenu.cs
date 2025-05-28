using UnityEngine;
using UnityEngine.SceneManagement; // só se quiseres recarregar a cena ou ir para outro menu
using UnityEngine.UI;

public class ExitMenuManager : MonoBehaviour
{
    public GameObject exitConfirmationPanel;  // painel de confirmação
    public GameObject mainMenuButtonsPanel;   // painel onde estão os botões principais (Start, Options, Exit)

    void Start()
    {
        // Garante que o painel de confirmação está desligado
        exitConfirmationPanel.SetActive(false);
        mainMenuButtonsPanel.SetActive(true);
    }

    // Chamado pelo botão Exit
    public void ShowExitConfirmation()
    {
        exitConfirmationPanel.SetActive(true);
        mainMenuButtonsPanel.SetActive(false);
    }

    // Chamado pelo botão Não
    public void CancelExit()
    {
        exitConfirmationPanel.SetActive(false);
        mainMenuButtonsPanel.SetActive(true);
    }

    // Chamado pelo botão Sim
    public void ConfirmExit()
    {
        // Se estiver no editor, só faz log para não fechar o editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit(); // fecha o jogo no build final
#endif
    }
}
