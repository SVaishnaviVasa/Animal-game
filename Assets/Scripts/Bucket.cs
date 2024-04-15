using UnityEngine;
using UnityEngine.EventSystems;

public class Bucket : MonoBehaviour, IDropHandler
{
    public string bucketColor; // "blue" or "red"
    public GameManager gameManager;

    public void OnDrop(PointerEventData eventData)
    {
        Card card = eventData.pointerDrag.GetComponent<Card>();
        if (card != null)
        {
            gameManager.CheckCardPlacement(card, bucketColor);
        }
    }
}
