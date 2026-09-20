using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    AudioManager audioManager;

    private void Start()
    {
        this.audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();  // 오디오 찾고
        this.audioManager.PlayBackground();      // 배경음 틀기
    }

    // 타이틀에서 플레이 누르면 쓸 함수
    public void Play()
    {
        // 소리내고 이동 하기
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("explanation");
    }

    // 타이틀에서 나가기 누르면 쓸 함수
    public void Quit()
    {
        // 유니티에서 실행하면 종료
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        // 에플리케이션이면 끄기
#else
        Application.Quit();
#endif
    }
}