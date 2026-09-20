using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplanationDirector : MonoBehaviour
{
    GameObject scene1;
    GameObject scene2;
    GameObject scene3;
    GameObject scene4;

    AudioManager audioManager;

    void Start()
    {
        this.audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();  // 오디오 찾기
        this.scene1 = GameObject.Find("scene1");

        // 첫 화면 제외 다른 화면 숨기기
        this.scene2 = GameObject.Find("scene2");
        this.scene2.SetActive(false);

        this.scene3 = GameObject.Find("scene3");
        this.scene3.SetActive(false);

        this.scene4 = GameObject.Find("scene4");
        this.scene4.SetActive(false);
    }

    public void next1()
    {
        this.audioManager.PlayButtonClick();     // 클릭 소릭
        // 지금 화면 숨기고 다음 화면 불러오기
        this.scene2.SetActive(true);
        this.scene1.SetActive(false);
    }

    public void next2()
    {
        this.audioManager.PlayButtonClick();      // 클릭 소릭
        // 지금 화면 숨기고 다음 화면 불러오기
        this.scene3.SetActive(true);
        this.scene2.SetActive(false);
    }

    public void next3()
    {
        this.audioManager.PlayButtonClick();     // 클릭 소릭
        // 지금 화면 숨기고 다음 화면 불러오기
        this.scene4.SetActive(true);
        this.scene3.SetActive(false);
    }

    public void finish()
    {
        this.audioManager.PlayButtonClick();      // 클릭 소릭
        // 끝나면 메인으로 이동
        SceneManager.LoadScene("MainGame");
    }
}
