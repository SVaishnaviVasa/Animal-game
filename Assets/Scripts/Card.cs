using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public string animalName;
    public string category;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Start Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
    }

    public string GetCategory()
    {
        return category;
    }

    public Animal thisAnimal; // Set this in the Inspector or via script

    void OnMouseDown() // Basic mouse click interaction
    {
        CardPopupManager.Instance.ShowCardInfo(thisAnimal);
    }

}
