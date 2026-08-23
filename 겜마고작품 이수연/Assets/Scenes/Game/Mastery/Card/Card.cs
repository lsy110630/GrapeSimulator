using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

// 씬이 시작되면 랜덤 카드 3개가 나오고 카드를 고르면 그 카드에 해당하는 능력치를 올리고 돌아간다
public class Card : MonoBehaviour
{
    public GameObject[] cards; // 전체 카드

    public int podo = 0;
    public int juice = 0;
    public int token = 0;         // 토큰 개수
    public int podoCount = 30;    // 포도개수
    public int time = 15;         // 시간증가
    public int pSP = 0;           // 포도 스폰확률
    public int bP = 0;            // 부숴질 확률
    public int addEX = 0;         // 추가 경험치



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
        SceneManager.LoadScene("Mastery");
    }

    public void Card2()
    {
        SceneManager.LoadScene("Mastery");
    }

    public void Card3()
    {
        SceneManager.LoadScene("Mastery");
    }

    public void Card4()
    {
        SceneManager.LoadScene("Mastery");
    }

    public void Card5()
    {
        SceneManager.LoadScene("Mastery");
    }

    public void Card6()
    {
        SceneManager.LoadScene("Mastery");
    }

    public void Card7()
    {
        SceneManager.LoadScene("Mastery");
    }

    public void Card8()
    {
        SceneManager.LoadScene("Mastery");
    }

    public void Card9()
    {
        SceneManager.LoadScene("Mastery");
    }

    public void Card10()
    {
        SceneManager.LoadScene("Mastery");
    }

}
