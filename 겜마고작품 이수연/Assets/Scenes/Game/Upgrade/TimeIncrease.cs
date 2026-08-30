using UnityEngine;

public class TimeIncrease : MonoBehaviour
{
    GameObject uDirector;
    GameObject tooltip;
    bool maxIncrease = false;   // 업그레이드 가능 판단

    GameObject btn1;

    void Start()
    {
        this.uDirector = GameObject.Find("UpgradeDirector");
        // 설명 찾고 숨기기
        this.tooltip = GameObject.Find("TimeIncreaseT");
        this.tooltip.SetActive(false);

        // 다음 업그레이드 숨기기
        this.btn1 = GameObject.Find("ValueIncrease");
        this.btn1.SetActive(false);
    }

    void Update()
    {
        // 업그레이드가 최대치인지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().tUN >= 5)
        {
            this.maxIncrease = true;
        }

        // 업그레이드가 되있으면 버튼을 보이게한다
        if (this.uDirector.GetComponent<UpgradeDirector>().tUN >= 1)
        {
            this.btn1.SetActive(true);
        }
    }

    public void Increase()
    {
        // 업그레이드가 가능한만큼 주스가 있는지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().jucie >= 10)
        {
            if (maxIncrease == false)
            {
                this.uDirector.GetComponent<UpgradeDirector>().tUN += 1;        // 업그레이드 넘버를 가져와 늘린다

                this.uDirector.GetComponent<UpgradeDirector>().jucie -= 10;     // juice를 가져와 줄인다

                this.uDirector.GetComponent<UpgradeDirector>().time += 1;       // 시간을 가져와 늘린다

                PlayerPrefs.SetInt("jucie", this.uDirector.GetComponent<UpgradeDirector>().jucie);
                PlayerPrefs.SetInt("time", this.uDirector.GetComponent<UpgradeDirector>().time);
                PlayerPrefs.SetInt("tUN", this.uDirector.GetComponent<UpgradeDirector>().tUN);
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
