using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    // Referências aos diferentes painéis
    public GameObject mainPanel;
    public GameObject individualPanel;
    public GameObject groupPanel;
    public GameObject gameHUD;
    public GameObject namesPanel; // Para criar os campos de nomes dinamicamente

    // Prefab para os campos de entrada de nomes
    public GameObject nameInputPrefab;

    // Variável para armazenar o nome do jogador
    public Text playerNameText; // Exibe o nome do jogador no HUD

    // Função para abrir o painel principal
    public void OpenMainPanel()
    {
        mainPanel.SetActive(true);
        individualPanel.SetActive(false);
        groupPanel.SetActive(false);
        gameHUD.SetActive(false);
    }

    // Função para abrir o painel individual
    public void OpenIndividualPanel()
    {
        mainPanel.SetActive(false);
        individualPanel.SetActive(true);
        groupPanel.SetActive(false);
    }

    // Função para abrir o painel de grupo
    public void OpenGroupPanel()
    {
        mainPanel.SetActive(false);
        individualPanel.SetActive(false);
        groupPanel.SetActive(true);
    }

    // Função para iniciar o jogo individualmente
    public void StartIndividualGame(InputField nameInput)
    {
        string playerName = nameInput.text;
        playerNameText.text = playerName; // Atualiza o HUD
        individualPanel.SetActive(false);
        gameHUD.SetActive(true); // Mostra o HUD do jogo
    }

    // Função para criar campos de entrada de nomes para o modo grupo
    public void CreateGroupInputs(InputField playerCountInput)
    {
        // Remove campos antigos
        foreach (Transform child in namesPanel.transform)
        {
            Destroy(child.gameObject);
        }

        int playerCount = int.Parse(playerCountInput.text);

        

        // Cria os novos campos de entrada
        for (int i = 0; i < playerCount; i++)
        {
            GameObject inputField = Instantiate(nameInputPrefab, namesPanel.transform);

            // Define a posição do campo
            RectTransform inputRect = inputField.GetComponent<RectTransform>();
            inputRect.anchoredPosition = new Vector2(0, -(i + 1) * -250); // Posiciona no eixo Y com espaçamento
            inputRect.sizeDelta = new Vector2(200 * 0.8f, 40); // Define largura proporcional e altura fixa

            inputField.GetComponent<InputField>().placeholder.GetComponent<Text>().text = $"Jogador {i + 1}";

        }
        // Ativa o painel de nomes e desativa o painel de grupo
        groupPanel.SetActive(true);
        namesPanel.SetActive(true); // Certifique-se de ter atribuído o NamesPanel no Inspector
    }

}
