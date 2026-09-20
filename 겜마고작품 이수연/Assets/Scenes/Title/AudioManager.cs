using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource backgroundAS;
    public AudioSource effectAS;

    public AudioClip backgroundClip;   // 배경음
    public AudioClip buttonClickClip;  // 클릭음
    public AudioClip podoClip;         // 포도 얻을때

    void Start()
    {
        DontDestroyOnLoad(gameObject);   // 이 오브젝트 못 지우게 하기
    }

    // 배경음
    public void PlayBackground()
    {
        backgroundAS.clip = backgroundClip;
        backgroundAS.Play();
    }

    // 버튼 누를때 소리
    public void PlayButtonClick()
    {
        effectAS.PlayOneShot(buttonClickClip);
    }

    // 포도 얻을때 소리
    public void podo()
    {
        effectAS.PlayOneShot(podoClip);
    }
}
