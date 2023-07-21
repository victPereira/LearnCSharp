using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float moveSpeed;
    public SpriteRenderer sprite;
    private Vector2 offset;
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = sprite.material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += Vector2.right * Time.deltaTime * moveSpeed;
        material.mainTextureOffset = offset;
    }
}
