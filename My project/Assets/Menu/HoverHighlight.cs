using UnityEngine;
using UnityEngine.EventSystems;

public class HoverHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject destaque; // Sprite visual

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (destaque != null)
            destaque.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (destaque != null)
            destaque.SetActive(false);
    }
}
