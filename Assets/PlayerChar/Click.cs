using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.gameObject.name);
                hit.collider.gameObject.SendMessage("PlayerClickedThis", SendMessageOptions.DontRequireReceiver);
            }
        }

    }
}
