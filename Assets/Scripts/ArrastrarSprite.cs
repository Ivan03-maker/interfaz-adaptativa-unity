using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarSprite : MonoBehaviour, IDragHandler
{
    // Este método se ejecuta automáticamente mientras mantienes presionado y arrastras el objeto
    public void OnDrag(PointerEventData eventData)
    {
        // Hace que la posición del sprite siga el cursor del mouse o toque en pantalla
        transform.position = eventData.position;
    }
}