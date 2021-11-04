using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float platformSpeed = 2f;
    public float bound_Y = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _platformMove();
    }

    void _platformMove()
    {
        Vector2 movePlatform = transform.position;
        movePlatform.y += Time.deltaTime * platformSpeed;
        transform.position = movePlatform;

        if(movePlatform.y >= bound_Y)
        {
            gameObject.SetActive(false);
        }
    }







}//class
















