using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustRunBaby : MonoBehaviour
{
    [SerializeField] private float _MoveSpeed;

    SpriteRenderer sr;
    
    
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        HorizontalMove();
    }

    private void HorizontalMove()
    {
        var value = _MoveSpeed * Time.deltaTime;
        transform.Translate(value * Vector3.right);
    }
}
