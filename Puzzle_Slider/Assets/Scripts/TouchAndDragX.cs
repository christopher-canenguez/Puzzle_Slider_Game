using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TouchAndDragX : MonoBehaviour
{
    private Vector3 _dragOffset;
    private Camera _cam;

    [SerializeField] private float _speed = 5;

    void Awake()
    {
        _cam = Camera.main;
    }

    void OnMouseDown()
    {
        _dragOffset = transform.position - GetMousePos();
        GameManager.Instance.currentMoves += 1;
    }

    void OnMouseDrag()
    {
        transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset, _speed * Time.deltaTime);
    }

    Vector3 GetMousePos()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = 0;
        mousePos.z = 0;
        return mousePos;
    }
}