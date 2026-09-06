using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarSprite : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        // Esto usa la posición del puntero del nuevo Input System
        transform.position = eventData.position;
    }
}
