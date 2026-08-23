using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timeout : MonoBehaviour
{
    GameObject clock;
    public float time = 15f;
    GameObject mDirector;

    void Start()
    {
        this.clock = GameObject.Find("Time");
        this.mDirector = GameObject.Find("MainDirector");
        this.time = PlayerPrefs.GetInt("time", 15);
    }

    void Update()
    {
        this.clock.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
        if (time <= 0)
        {
            // 데이터 저장
            PlayerPrefs.SetInt("podo", this.mDirector.GetComponent<MainGameDirector>().podo);

            // 주스 데이터 불러와서 누적
            int juice = PlayerPrefs.GetInt("juice", 0); // 원래 주스 개수
            juice += this.mDirector.GetComponent<MainGameDirector>().podo / 3; // 포도 / 3 만큼 추가
            PlayerPrefs.SetInt("juice", juice); // 저장

            PlayerPrefs.SetInt("token", this.mDirector.GetComponent<MainGameDirector>().token);

            // 생성되는 포도 개수 저장
            PlayerPrefs.SetInt("podoCount", this.mDirector.GetComponent<MainGameDirector>().podoCount);

            PlayerPrefs.SetInt("value", this.mDirector.GetComponent<MainGameDirector>().value);

            int time = PlayerPrefs.GetInt("time", 15);
            PlayerPrefs.SetInt("time", time);

            PlayerPrefs.SetFloat("speed", this.mDirector.GetComponent<MainGameDirector>().speed);

            PlayerPrefs.SetInt("pSP", this.mDirector.GetComponent<MainGameDirector>().pSP);

            PlayerPrefs.SetInt("bP", this.mDirector.GetComponent<MainGameDirector>().bP);

            PlayerPrefs.SetInt("artiP", this.mDirector.GetComponent<MainGameDirector>().artiP);

            PlayerPrefs.SetInt("shosepodo", this.mDirector.GetComponent<MainGameDirector>().shosepodo);
            PlayerPrefs.SetInt("scissorspodo", this.mDirector.GetComponent<MainGameDirector>().scissorspodo);
            PlayerPrefs.SetInt("glovepodo", this.mDirector.GetComponent<MainGameDirector>().glovepodo);
            PlayerPrefs.SetInt("hatpodo", this.mDirector.GetComponent<MainGameDirector>().hatpodo);
            PlayerPrefs.SetInt("overallspodo", this.mDirector.GetComponent<MainGameDirector>().overallspodo);

            PlayerPrefs.SetInt("level", this.mDirector.GetComponent<MainGameDirector>().level);
            PlayerPrefs.SetInt("EX", this.mDirector.GetComponent<MainGameDirector>().EX);
            PlayerPrefs.SetInt("maxEX", this.mDirector.GetComponent<MainGameDirector>().maxEX);

            PlayerPrefs.SetInt("addEX", this.mDirector.GetComponent<MainGameDirector>().addEX);

            PlayerPrefs.Save();

            SceneManager.LoadScene("Upgrade");
        }
        else
        {
            time -= 0.01f;
        }
    }
}
