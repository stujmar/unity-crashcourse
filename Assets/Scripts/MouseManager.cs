using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class MouseManager : MonoBehaviour
{
    // Know what objects are clickable.
    public LayerMask clickableLayer;

    // Swap cursors for different objects.
    public Texture2D pointer; // Normal pointer.
    public Texture2D target; // Clickable pointer.
    public Texture2D doorway; // Doorway pointer.
    public Texture2D combat; // Combat pointer.
    public Texture2D chest; // Chest pointer.

    public EventVector3 OnClickEnvironment;

    // Start is called before the first frame update
    /* void Start()
    {
        
    } */

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
        {
            bool isDoor = false;
            bool isChest = false;

            if(hit.collider.gameObject.tag == "Doorway")
            {
                Cursor.SetCursor(doorway, new Vector2(16, 16), CursorMode.Auto);
                isDoor = true;
            } else if (hit.collider.gameObject.tag == "Chest")
            {
          
                Cursor.SetCursor(chest, new Vector2(16, 16), CursorMode.Auto);
                isChest = true;
                Debug.Log("Chest Hover");
            } else
            {
                Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
            }
            if(Input.GetMouseButtonDown(0))
            {
                if(isDoor)
                {
                    Transform doorway = hit.collider.gameObject.transform;
                    OnClickEnvironment.Invoke(doorway.position);
                    Debug.Log("DOOR");
                }
                else if (isChest)
                {
                    Transform chestPos = hit.collider.gameObject.transform;
                    OnClickEnvironment.Invoke(chestPos.position);
                    Debug.Log("Chest");

                } else
                {
                OnClickEnvironment.Invoke(hit.point);
                }

            }
        } else
        {
            Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
        }
    }
}

[System.Serializable]
public class EventVector3 : UnityEvent<Vector3> { }
