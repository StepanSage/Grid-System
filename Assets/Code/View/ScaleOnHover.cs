using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleOnHover : MonoBehaviour
{
    private const float ADD_SCALE = 1.2f;
    private const float SPEED_SCALE = 1f;
    private const float CELECR_COLOR = 1.1f;

    private Vector3 _originalScale;
    private Color _defualtColor;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _originalScale = transform.localScale;
        _defualtColor = GetComponent<SpriteRenderer>().color;
        _spriteRenderer= GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        transform.DOScale(_originalScale * ADD_SCALE, SPEED_SCALE);
        _spriteRenderer.sortingOrder = 2;
        _spriteRenderer.DOColor(_defualtColor * CELECR_COLOR, -1);
    }

    private void OnMouseExit()
    {
        transform.DOScale(_originalScale, SPEED_SCALE);
        _spriteRenderer.sortingOrder = -1;
        _spriteRenderer.DOColor(_defualtColor, -1);
    }
}
