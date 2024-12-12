using UnityEngine;
using UnityEngine.UI;

public class GameplayUI : MonoBehaviour
{
    [SerializeField] private Text playerNameText;

    void Start()
    {
        if (playerNameText != null)
        {
            playerNameText.text = PlayerData.PlayerName;
        }
    }
}
