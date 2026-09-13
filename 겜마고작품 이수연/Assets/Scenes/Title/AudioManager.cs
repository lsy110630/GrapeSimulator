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
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
    }

    public void PlayBackground()
    {
        backgroundAS.clip = backgroundClip;
        backgroundAS.Play();
    }

    public void PlayButtonClick()
    {
        effectAS.PlayOneShot(buttonClickClip);
    }

    public void podo()
    {
        effectAS.PlayOneShot(podoClip);
    }
}
