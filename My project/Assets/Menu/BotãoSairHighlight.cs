using UnityEngine;
using UnityEngine.EventSystems;

public class BotaoSairHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject destaqueSair; // A imagem que aparece ao passar o mouse

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (destaqueSair != null)
            destaqueSair.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (destaqueSair != null)
            destaqueSair.SetActive(false);
    }
}
