using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [Header("Properties")]
    [Space]
    [SerializeField] private float _moveSpeed = 2.0f;
    [Space]
    [Header("Pipe Parts")]
    [Space]
    public SpriteRenderer Pipe_Up;
    public SpriteRenderer Pipe_Down;
    public SpriteRenderer[] Pipe_General;
    public Sprite[] pipe_Up_Template;
    public Sprite[] pipe_Down_Template;
    public Sprite[] pipe_General_Template;
    [Space]
    [Header("Colliders")]
    [Space]
    public BoxCollider2D[] _deathCollider;
    public BoxCollider2D _scoringCollider;

    private bool _shouldMove = true;
    void Start()
    {
        Locator.Instance.Player.OnDeath += StopMoving;
        int rand = Random.Range(0, pipe_Up_Template.Length);
        Pipe_Up.sprite = pipe_Up_Template[rand];
        Pipe_Down.sprite = pipe_Down_Template[rand];
        for(int i = 0; i < Pipe_General.Length; i++)
        {
            Pipe_General[i].sprite = pipe_General_Template[rand];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_shouldMove)
        {
            transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Locator.Instance.Player.AddScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Locator.Instance.Player.Die();
        }
    }
    private void StopMoving()
    {
        _shouldMove = false;
    }
}

