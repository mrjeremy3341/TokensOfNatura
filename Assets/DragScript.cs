using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public Transform returnParent = null;
	public bool isDraggable = false;

	public void OnBeginDrag(PointerEventData eventData)
	{
		if (isDraggable)
		{
			returnParent = this.transform.parent;
			this.transform.SetParent(this.transform.root);

			GetComponent<CanvasGroup>().blocksRaycasts = false;
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (isDraggable)
		{
			transform.position = eventData.position;
		}	
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if (isDraggable)
		{
			this.transform.SetParent(returnParent);

			GetComponent<CanvasGroup>().blocksRaycasts = true;
		}
	}	

	public void Update()
	{
		if (returnParent != null)
		{
			if (this.transform.position == returnParent.transform.position && returnParent != this.transform.root)
			{
				this.enabled = false;
			}
		}
	}
}
