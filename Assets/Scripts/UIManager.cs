using UnityEngine;
using TMPro; // Include TextMeshPro namespace

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Change Text to TextMeshProUGUI
    public TextMeshProUGUI blueCategoryText; // Change Text to TextMeshProUGUI
    public TextMeshProUGUI redCategoryText; // Change Text to TextMeshProUGUI
    public GameObject finishScreen;

    public void SetCategories(string blue, string red)
    {
        blueCategoryText.text = blue;
        redCategoryText.text =  red;
    }

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void ShowFinishScreen()
    {
        finishScreen.SetActive(true);
    }
}
