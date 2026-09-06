using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Card : MonoBehaviour
{
    public GameObject[] cards; // 전체 카드

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
        foreach (var card in cards)
        {
            card.gameObject.SetActive(false);
        }


        int card1 = Random.Range(0, cards.Length); // 첫번째 카드의 배열 번호
        cards[card1].GetComponent<RectTransform>().anchoredPosition = new Vector3(-600, 0, 0);
        cards[card1].SetActive(true);

        int card2 = Random.Range(0, cards.Length); //두번째 카드의 배열 번호
        while (card1 == card2)
        {
            card2 = Random.Range(0, cards.Length);
            if (card1 != card2)
            {
                break;
            }
        }
        cards[card2].GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        cards[card2].SetActive(true);

        int card3 = Random.Range(0, cards.Length); // 세번째 카드의 배열 번호
        while (card1 == card3 || card2 == card3)
        {
            card3 = Random.Range(0, cards.Length);
            if (card1 != card3 && card2 != card3)
            {
                break;
            }
        }
        cards[card3].GetComponent<RectTransform>().anchoredPosition = new Vector3(600, 0, 0);
        cards[card3].SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Card");
        } 
    }

    public void Card1()
    {
        this.speed += speed * 1.1f;
        PlayerPrefs.SetFloat("speed", speed);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Card2()
    {
        this.podoCount += 1;
        PlayerPrefs.SetInt("podoCount", podoCount);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Card3()
    {
        this.artiP += 1;
        PlayerPrefs.SetInt("artiP", artiP);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Card4()
    {
        this.time += 1;
        PlayerPrefs.SetInt("time", time);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Card5()
    {
        this.artiP += 5;
        PlayerPrefs.SetInt("artiP", artiP);
        this.badP += 1;
        PlayerPrefs.SetInt("badP", badP);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Card6()
    {
        this.speed += speed * 1.3f;
        PlayerPrefs.SetFloat("speed", speed);
        this.badP += 1;
        PlayerPrefs.SetInt("badP", badP);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Card7()
    {
        this.podoCount += 5;
        PlayerPrefs.SetInt("podoCount", podoCount);
        this.badP += 1;
        PlayerPrefs.SetInt("badP", badP);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Card8()
    {
        this.goodP += 1;
        PlayerPrefs.SetInt("goodP", goodP);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Card9()
    {
        this.goodP += 1;
        PlayerPrefs.SetInt("goodP", goodP);
        this.value += 1;
        PlayerPrefs.SetInt("value", value);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

    public void Card10()
    {
        this.goodP += 3;
        PlayerPrefs.SetInt("goodP", goodP);
        this.badP += 3;
        PlayerPrefs.SetInt("badP", badP);

        PlayerPrefs.Save();
        SceneManager.LoadScene("Mastery");
    }

}
