using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GrapeIncrease : MonoBehaviour
{
    GameObject uDirector;
    GameObject tooltip;
    bool maxIncrease = false;   // 업그레이드 가능 판단

    GameObject btn1;
    GameObject btn2;
    GameObject btn3;
    GameObject btn4;

    void Start()
    {
        this.uDirector = GameObject.Find("UpgradeDirector");
        // 설명 찾고 숨기기
        this.tooltip = GameObject.Find("GrapeIncreaseT");
        this.tooltip.SetActive(false);

        // 2단계 업그레이드 버튼 모두 찾아놓기 & 숨기기
        this.btn1 = GameObject.Find("TimeIncrease");
        this.btn1.SetActive(false);
        this.btn2 = GameObject.Find("PodoSpawn");
        this.btn2.SetActive(false);
        this.btn3 = GameObject.Find("Broke");
        this.btn3.SetActive(false);
        this.btn4 = GameObject.Find("EXIncrease");
        this.btn4.SetActive(false);
    }

    void Update()
    {
        // 업그레이드가 최대치인지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().gUN >= 5)
        {
            this.maxIncrease = true;
        }

        // 업그레이드가 되있으면 버튼을 보이게한다
        if (this.uDirector.GetComponent<UpgradeDirector>().gUN >= 1)
        {
            this.btn1.SetActive(true);
            this.btn2.SetActive(true);
            this.btn3.SetActive(true);
            this.btn4.SetActive(true);
        }
    }

    public void Increase()
    {
        // 업그레이드가 가능한만큼 주스가 있는지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().jucie >= 5)
        {
            if (maxIncrease == false)
            {
                this.uDirector.GetComponent<UpgradeDirector>().gUN += 1;      // 업그레이드 넘버를 가져와 늘린다

                this.uDirector.GetComponent<UpgradeDirector>().jucie -= 5;     // juice를 가져와 줄인다

                this.uDirector.GetComponent<UpgradeDirector>().podoCount += 1; // 포도개수를 가져와 늘린다

                PlayerPrefs.SetInt("jucie", this.uDirector.GetComponent<UpgradeDirector>().jucie);
                PlayerPrefs.SetInt("podoCount", this.uDirector.GetComponent<UpgradeDirector>().podoCount);
                PlayerPrefs.SetInt("gUN", this.uDirector.GetComponent<UpgradeDirector>().gUN);
                PlayerPrefs.Save();
            }
        }
    }

    public void ShowTooltip()
    {
        this.tooltip.SetActive(true);
    }

    public void HideTooltip()
    {
        this.tooltip.SetActive(false);
    }
}
