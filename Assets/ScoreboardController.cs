using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreboardController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private int _playerHeight;
    private int _prevPlayerHeight;

    public Transform playerPosition;

    void Start()
    {
        _scoreText.SetText("0");
        playerPosition = GameObject.FindGameObjectsWithTag("Player")[0].transform;
    }

    void Update()
    {
        _playerHeight = (int)playerPosition.transform.position.y;

        if (_playerHeight > _prevPlayerHeight)
        {
            _scoreText.SetText($"{_playerHeight}");
            _prevPlayerHeight = _playerHeight;
        }
    }
}
