using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Card : MonoBehaviour
{
    public GameObject[] cards; // 전체 카드 담는 변수
    AudioManager audioManager;

    public int podo = 0;
    public int juice = 0;
    public int token = 0;           // 토큰 개수
    public int podoCount = 30;      // 포도개수
    public int time = 15;           // 시간증가
    public int pSP = 0;             // 포도 스폰확률
    public int bP = 0;              // 부숴질 확률
    public int addEX = 0;           // 추가 경험치
    public int artiP = 1;           // 아티팩트 확률
    public float speed = 0.03f;     // 속도
    public float span = 3.0f;       // 획득속도
    public int badP = 0;            // 안 좋은 이벤트 확률
    public int goodP = 0;           // 좋은 이벤트 확률
    public int value = 1;           // 가치

    private void Awake()
    {
        this.audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();

        this.podo = PlayerPrefs.GetInt("podo", 0);
        this.juice = PlayerPrefs.GetInt("juice", 0);
        this.token = PlayerPrefs.GetInt("token", 0);
        this.podoCount = PlayerPrefs.GetInt("podoCount", 30);
        this.time = PlayerPrefs.GetInt("time", 15);
        this.pSP = PlayerPrefs.GetInt("pSP", 0);
        this.bP = PlayerPrefs.GetInt("bP", 0);
        this.addEX = PlayerPrefs.GetInt("addEX", 0);
        this.artiP = PlayerPrefs.GetInt("artiP", 1);
        this.speed = PlayerPrefs.GetFloat("speed", 0.03f);
        this.span = PlayerPrefs.GetFloat("span", 3.0f);
        this.badP = PlayerPrefs.GetInt("badP", 0);
        this.goodP = PlayerPrefs.GetInt("goodP", 0);
        this.value = PlayerPrefs.GetInt("value", 1);
    }


    void Start()
    {
        // 전체 카드 비활성화
        // foreach 카드 안에 있는걸 하나씩 꺼내서 반복
        // var card 현재 카드 안에서 꺼낸 카드
        foreach (var card in cards)
        {
            // 숨기기
            card.gameObject.SetActive(false);
        }

        // cards.Length 배열의 총 개수 지금은 10인거 그러니까 0~9까지
        int card1 = Random.Range(0, cards.Length); // 첫번째 카드의 배열 번호
        cards[card1].GetComponent<RectTransform>().anchoredPosition = new Vector3(-600, 0, 0);
        cards[card1].SetActive(true);

        int card2 = Random.Range(0, cards.Length); //두번째 카드의 배열 번호
        // 1과 2가 같으면 반복
        while (card1 == card2)
        {
            card2 = Random.Range(0, cards.Length);
        }
        cards[card2].GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        cards[card2].SetActive(true);

        int card3 = Random.Range(0, cards.Length); // 세번째 카드의 배열 번호
        // 1과 3, 2와 3이 같으니 반복
        while (card1 == card3 || card2 == card3)
        {
            card3 = Random.Range(0, cards.Length);
        }
        cards[card3].GetComponent<RectTransform>().anchoredPosition = new Vector3(600, 0, 0);
        cards[card3].SetActive(true);
    }

    // 카드 1~10 까지 고를떄 쓸 함수들
    public void Card1() // 스피드가 1.1배 증가한다
    {
        this.speed += speed * 1.1f;
        PlayerPrefs.SetFloat("speed", speed);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

    public void Card2()  // 시작할때 포도의 개수가 1개 증가한다
    {
        this.podoCount += 1;
        PlayerPrefs.SetInt("podoCount", podoCount);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

    public void Card3()  // 아티팩트가 나올 확률이 1% 증가한다
    {
        this.artiP += 1;
        PlayerPrefs.SetInt("artiP", artiP);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

    public void Card4()  // 게임시간이 1초 증가한다
    {
        this.time += 1;
        PlayerPrefs.SetInt("time", time);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

    public void Card5()  // 아티팩트가 나올 확률이 5% 증가하며 안 좋은 이벤트 발생 확률이 1% 증가한다 
    {
        this.artiP += 5;
        PlayerPrefs.SetInt("artiP", artiP);
        this.badP += 1;
        PlayerPrefs.SetInt("badP", badP);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

    public void Card6()  // 스피드가 1.3배 증가하며 안 좋은 이벤트 발생 확률이 1% 증가한다 
    {
        this.speed += speed * 1.3f;
        PlayerPrefs.SetFloat("speed", speed);
        this.badP += 1;
        PlayerPrefs.SetInt("badP", badP);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

    public void Card7()  // 시작할때 포도 개수가 5개 증가하며 안 좋은 이벤트 발생 확률이 1% 증가한다 
    {
        this.podoCount += 5;
        PlayerPrefs.SetInt("podoCount", podoCount);
        this.badP += 1;
        PlayerPrefs.SetInt("badP", badP);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

    public void Card8()  // 좋은 이벤트 발생 확률이 1% 증가한다 
    {
        this.goodP += 1;
        PlayerPrefs.SetInt("goodP", goodP);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

    public void Card9()  // 가치가 1 증가하며 좋은 이벤트 발생 확률이 1% 증가한다 
    {
        this.goodP += 1;
        PlayerPrefs.SetInt("goodP", goodP);
        this.value += 1;
        PlayerPrefs.SetInt("value", value);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

    public void Card10()  // 각 이벤트 발생 확률이 3% 씩 증가한다 
    {
        this.goodP += 3;
        PlayerPrefs.SetInt("goodP", goodP);
        this.badP += 3;
        PlayerPrefs.SetInt("badP", badP);

        PlayerPrefs.Save();
        this.audioManager.PlayButtonClick();
        SceneManager.LoadScene("Mastery");
    }

}
