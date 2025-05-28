using UnityEngine;
using UnityEngine.SceneManagement; // s� se quiseres recarregar a cena ou ir para outro menu
using UnityEngine.UI;

public class ExitMenuManager : MonoBehaviour
{
    public GameObject exitConfirmationPanel;  // painel de confirma��o
    public GameObject mainMenuButtonsPanel;   // painel onde est�o os bot�es principais (Start, Options, Exit)

    void Start()
    {
        // Garante que o painel de confirma��o est� desligado
        exitConfirmationPanel.SetActive(false);
        mainMenuButtonsPanel.SetActive(true);
    }

    // Chamado pelo bot�o Exit
    public void ShowExitConfirmation()
    {
        exitConfirmationPanel.SetActive(true);
        mainMenuButtonsPanel.SetActive(false);
    }

    // Chamado pelo bot�o N�o
    public void CancelExit()
    {
        exitConfirmationPanel.SetActive(false);
        mainMenuButtonsPanel.SetActive(true);
    }

    // Chamado pelo bot�o Sim
    public void ConfirmExit()
    {
        // Se estiver no editor, s� faz log para n�o fechar o editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit(); // fecha o jogo no build final
#endif
    }
}
