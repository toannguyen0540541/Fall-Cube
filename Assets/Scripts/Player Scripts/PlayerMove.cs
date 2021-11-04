using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D myBody;
    public float playerSpeed = 2f;



    private bool moveLeft, moveRight;



    public void setMoveLeft(bool moveLeft)
    {
        this.moveLeft = moveLeft;
        this.moveRight = !moveLeft;
    }
    public void stopMoving()
    {
        this.moveLeft = false;
        this.moveRight = false;
    }

    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _playerMove();
        _JoyStick();
    }

    void _playerMove()
    {
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myBody.velocity = new Vector2(playerSpeed, myBody.velocity.y);
        }
        if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            myBody.velocity = new Vector2(-playerSpeed, myBody.velocity.y);
        }
    }

    void _JoyStick()
    {
        if (moveRight)
        {
            myBody.velocity = new Vector2(playerSpeed, myBody.velocity.y);
        }
        if (moveLeft)
        {
            myBody.velocity = new Vector2(-playerSpeed, myBody.velocity.y);
        }
    }




}//class












