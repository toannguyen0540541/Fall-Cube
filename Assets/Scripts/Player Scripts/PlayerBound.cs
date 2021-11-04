using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBound : MonoBehaviour
{

    private float min_X = -2.6f, max_X = 2.6f, min_Y = -8;


    private bool out_Of_Bounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _checkBound();
    }

    void _checkBound()
    {
        Vector2 temp = transform.position;
        if(temp.x < min_X)
        {
            temp.x = min_X;
        }
        if(temp.x > max_X)
        {
            temp.x = max_X;
        }
        transform.position = temp;

        if (temp.y < min_Y)
        {

            if (!out_Of_Bounds)
            {

                out_Of_Bounds = true;
                SoundManager.instance.DeathSound();
                GameManager.instance.RestartGame();

            }

        }
    }


    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Spike")
        {
            transform.position = new Vector2(1000f, 1000f);
            SoundManager.instance.DeathSound();
            GameManager.instance.RestartGame();
        }
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Land")
        {
            SoundManager.instance.LandSound();
        }
    }





}//class











