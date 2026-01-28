using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float _pipeSpawnCD = 2.0f;
    [SerializeField] private Pipe _pipePrefab;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private AudioSource _scoreSound;
    [SerializeField] private AudioSource _jumpSound;
    [SerializeField] private AudioSource _DeathSound;
    private bool _gameOver = false;
    private int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.Player.OnDeath += GameOver;
        Locator.Instance.Player.OnScore += Score;
        Locator.Instance.Player.OnJump += JumpSound;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_gameOver)
        {
            if (_pipeSpawnCD <= 0f)
            {
                SpawnPipe();
                _pipeSpawnCD = 2.0f;
            }
            _pipeSpawnCD -= Time.deltaTime;
            if (transform.position.x <= -12.0f)
            {
                Destroy(gameObject);
            }
        }
    }
    private void SpawnPipe()
    {
        Instantiate(_pipePrefab, new Vector3(10.0f, Random.Range(-1.5f, 3.5f), 0.0f), Quaternion.identity);
    }
    private void GameOver()
    {
        _gameOver = true;
        _DeathSound.Play();
    }
    private void Score()
    {
        _score++;
        _scoreText.text = "Score: " + _score.ToString();
        _scoreSound.Play();
    }
    private void JumpSound()
    {
        _jumpSound.Play();
    }
}
