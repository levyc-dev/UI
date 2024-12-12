using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private InputField playerNameInput;

    public void LoadSceneWithPlayerName(int sceneIndex)
    {
        // Salva o nome do jogador
        if (playerNameInput != null)
        {
            PlayerData.PlayerName = playerNameInput.text;
        }

        // Troca para a cena desejada
        SceneManager.LoadScene(sceneIndex);
    }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
