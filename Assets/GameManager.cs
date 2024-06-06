using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // 이 스크립트는 완전히 가져옴.
    public GameObject gameOverUI;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 게임 오버 처리 함수
    public void GameOver()
    {
        // 게임 오버 UI를 활성화합니다.
        gameOverUI.SetActive(true);
        
        // 게임을 멈춥니다.
        Time.timeScale = 0f;
    }
}
