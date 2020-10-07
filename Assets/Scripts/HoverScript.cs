using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public  GameObject placeholderPrefab;

    private GameObject placeholder;
    private Sprite sprite;

    private void Start()
    {
        sprite = this.GetComponent<Image>().sprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Vector3 pos = new Vector3();
        pos.x = this.transform.position.x;
        pos.y = this.transform.position.y + 120;
        pos.z = this.transform.position.z;
        
        this.GetComponent<CanvasGroup>().alpha = 0;
        placeholder = Instantiate(placeholderPrefab, pos, Quaternion.identity, this.transform.root);
        placeholder.GetComponent<Image>().sprite = sprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.GetComponent<CanvasGroup>().alpha = 1;
        Object.DestroyImmediate(placeholder);
    }
}
