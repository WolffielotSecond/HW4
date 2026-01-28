using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [Header("Pipe Parts")]
    [Space]
    public SpriteRenderer Pipe_Up;
    public SpriteRenderer Pipe_Down;
    public SpriteRenderer[] Pipe_General;
    [Space]
    [Header("Colliders")]
    [Space]
    public BoxCollider2D[] _deathCollider;
    public BoxCollider2D _scoringCollider;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
