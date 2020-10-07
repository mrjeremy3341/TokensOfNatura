using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropScript : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
	{
		DragScript dragObject = eventData.pointerDrag.GetComponent<DragScript>();

		dragObject.returnParent = this.transform;
	}
}
