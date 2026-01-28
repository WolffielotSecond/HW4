using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void ScoreActions();
    public delegate void DeathActions();
    public delegate void JumpActions();
    public event ScoreActions OnScore;
    public event DeathActions OnDeath;
    public event JumpActions OnJump;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * 4.0f;
            OnJump?.Invoke();
        }
    }
    public void AddScore()
    {
        OnScore?.Invoke();
    }
    public void Die()
    {
        OnDeath?.Invoke();
        this.enabled = false;
    }
}
