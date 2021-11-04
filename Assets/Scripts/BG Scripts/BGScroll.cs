using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scrollSpeed = 0.3f;


    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _scroll();
    }
    
    void _scroll()
    {
        Vector2 offer = meshRenderer.sharedMaterial.GetTextureOffset("_MainTex");
        offer.y += Time.deltaTime * scrollSpeed;

        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offer);
    }
}
