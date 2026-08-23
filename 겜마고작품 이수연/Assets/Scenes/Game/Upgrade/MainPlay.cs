using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPlay : MonoBehaviour
{
    GameObject uDirector;

    private void Start()
    {
        this.uDirector = GameObject.Find("UpgradeDirector");
    }

    public void MPlay()
    {
        // 필수 데이터 저장
        PlayerPrefs.SetInt("podo", this.uDirector.GetComponent<UpgradeDirector>().podo);
        PlayerPrefs.SetInt("juice", this.uDirector.GetComponent<UpgradeDirector>().juice);
        PlayerPrefs.SetInt("token", this.uDirector.GetComponent<UpgradeDirector>().token);
        PlayerPrefs.SetInt("podoCount", this.uDirector.GetComponent<UpgradeDirector>().podoCount);
        PlayerPrefs.SetInt("time", this.uDirector.GetComponent<UpgradeDirector>().time);
        PlayerPrefs.SetInt("pSP", this.uDirector.GetComponent<UpgradeDirector>().pSP);
        PlayerPrefs.SetInt("bP", this.uDirector.GetComponent<UpgradeDirector>().bP);

        PlayerPrefs.SetInt("addEX", this.uDirector.GetComponent<UpgradeDirector>().addEX);

        PlayerPrefs.SetInt("gUN", this.uDirector.GetComponent<UpgradeDirector>().gUN);
        PlayerPrefs.SetInt("tUN", this.uDirector.GetComponent<UpgradeDirector>().tUN);
        PlayerPrefs.SetInt("pSPUN", this.uDirector.GetComponent<UpgradeDirector>().pSPUN);
        PlayerPrefs.SetInt("bPUN", this.uDirector.GetComponent<UpgradeDirector>().bPUN);

        PlayerPrefs.SetInt("EXUN", this.uDirector.GetComponent<UpgradeDirector>().EXUN);

        PlayerPrefs.SetFloat("speed", this.uDirector.GetComponent<UpgradeDirector>().speed);

        PlayerPrefs.SetInt("artiP", this.uDirector.GetComponent<UpgradeDirector>().artiP);

        PlayerPrefs.SetInt("shosepodo", this.uDirector.GetComponent<UpgradeDirector>().shosepodo);
        PlayerPrefs.SetInt("scissorspodo", this.uDirector.GetComponent<UpgradeDirector>().scissorspodo);
        PlayerPrefs.SetInt("glovepodo", this.uDirector.GetComponent<UpgradeDirector>().glovepodo);
        PlayerPrefs.SetInt("hatpodo", this.uDirector.GetComponent<UpgradeDirector>().hatpodo);
        PlayerPrefs.SetInt("overallspodo", this.uDirector.GetComponent<UpgradeDirector>().overallspodo);

        PlayerPrefs.Save();

        SceneManager.LoadScene("MainGame");
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("podo", 0);
        PlayerPrefs.SetInt("juice", 0);
        PlayerPrefs.SetInt("podoCount", 30);
        PlayerPrefs.SetInt("gUN", 0);
        PlayerPrefs.SetInt("time", 15);
        PlayerPrefs.SetInt("tUN", 0);
        PlayerPrefs.SetInt("pSP", 0);
        PlayerPrefs.SetInt("pSPUN", 0);
        PlayerPrefs.SetInt("bP", 0);
        PlayerPrefs.SetInt("bPUN", 0);

        PlayerPrefs.SetInt("level", 0); 
        PlayerPrefs.SetInt("token", 0);
        PlayerPrefs.SetInt("EX", 0);
        PlayerPrefs.SetInt("maxEX", 50);

        PlayerPrefs.SetInt("addEX", 0);
        PlayerPrefs.SetInt("EXUN", 0);

        PlayerPrefs.SetFloat("speed", 0.03f);

        PlayerPrefs.SetInt("artiP", 1);

        PlayerPrefs.SetInt("shosepodo", 0);
        PlayerPrefs.SetInt("scissorspodo", 0);
        PlayerPrefs.SetInt("glovepodo", 0);
        PlayerPrefs.SetInt("hatpodo", 0);
        PlayerPrefs.SetInt("overallspodo", 0);

        PlayerPrefs.Save();

        SceneManager.LoadScene("MainGame");
    }
}