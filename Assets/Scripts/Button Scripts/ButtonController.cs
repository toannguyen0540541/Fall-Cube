using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private PlayerMove player;

    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMove>();
    }


    public void OnPointerDown(PointerEventData data)
    {
        if (gameObject.name == "Button Left")
        {
            player.setMoveLeft(true);
        } else
        {
            player.setMoveLeft(false);
        }
    }
    public void OnPointerUp(PointerEventData data)
    {
        player.stopMoving();
    }
}
