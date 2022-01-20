using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBucket : MonoBehaviour
{
    public SpriteRenderer _spriteRenderer;
    public Sprite _sprite;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            _spriteRenderer.sprite = _sprite;
        }
    }
}
