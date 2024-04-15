using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public List<string> categories = new List<string> { "Flying", "Non-Flying", "Insect", "Non-Insect", "Omnivorous", "Herbivorous", "Group", "Solo", "Lays Eggs", "Gives Birth" };
    public string blueBucketCategory;
    public string redBucketCategory;
    public AnimalData animalData;
    public UIManager uiManager;
    public CardPopupManager cardPopupManager;

    private Dictionary<string, bool> scoreDict = new Dictionary<string, bool>();

    void Start()
    {
        RandomizeCategories();
        uiManager.SetCategories(blueBucketCategory, redBucketCategory);
    }

    void RandomizeCategories()
    {
        blueBucketCategory = categories[Random.Range(0, categories.Count)];
        do
        {
            redBucketCategory = categories[Random.Range(0, categories.Count)];
        } while (redBucketCategory == blueBucketCategory);
    }

    private string GenerateCardDetails(Card card)
    {
        // Return only the name and description of the animal associated with the card
        return $"Name: {animalData.name}";
    }

    public void OnCardSelected(Card card)
    {
        string details = GenerateCardDetails(card);
        if (cardPopupManager != null)
        {
            //CardPopupManager.ShowCardInfo(animalData.name,details);
        }
    }

    public void CheckCardPlacement(Card card, string bucketColor)
    {
        bool isCorrect = false;
        string animalCategory = card.GetCategory();

        if (bucketColor == "blue" && animalCategory == blueBucketCategory)
            isCorrect = true;
        else if (bucketColor == "red" && animalCategory == redBucketCategory)
            isCorrect = true;

        if (isCorrect)
        {
            scoreDict[animalData.name] = true;
            uiManager.UpdateScore(scoreDict.Count);
        }
        else
        {
            scoreDict[animalData.name] = false;
        }
    }

    public void FinishGame()
    {
        uiManager.ShowFinishScreen();
    }
}
