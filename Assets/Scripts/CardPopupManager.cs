using UnityEngine;
using TMPro;

public class CardPopupManager : MonoBehaviour
{
    public static CardPopupManager Instance; // Singleton instance

    public GameObject panel;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText; // Assuming you use TextMeshPro for better formatting

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ShowCardInfo(Animal animal)
    {
        nameText.text = animal.name;
        descriptionText.text = animal.description; // Set unique text
        panel.SetActive(true);
    }

    public void HideCardInfo()
    {
        panel.SetActive(false);
    }
}
