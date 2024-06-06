using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadScene : MonoBehaviour
{
    // 버튼을 Inspector에서 할당할 수 있도록 public으로 선언
    public Button rb;

    void Start()
    {
        // 버튼에 클릭 이벤트 리스너 추가
        if (rb != null)
        {
            rb.onClick.AddListener(ReloadCurrentScene);
        }
    }

    // 현재 씬을 다시 로드하는 함수
    void ReloadCurrentScene()
    {
        // 현재 활성화된 씬의 이름을 가져옴
        string sceneName = SceneManager.GetActiveScene().name;
        // 씬 다시 로드
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }
}
