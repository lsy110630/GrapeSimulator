using UnityEngine;

public class SpanDecrease : MonoBehaviour
{
    GameObject uDirector;
    GameObject tooltip;
    bool maxIncrease = false;   // 업그레이드 가능 판단

    GameObject btn;

    void Start()
    {
        this.uDirector = GameObject.Find("UpgradeDirector");
        // 설명 찾고 숨기기
        this.tooltip = GameObject.Find("SpanDecreaseT");
        this.tooltip.SetActive(false);

        // 이 버튼을 숨긴다
        this.btn = GameObject.Find("SpanDecrease");
        this.btn.SetActive(false);
    }

    void Update()
    {
        // 업그레이드가 최대치인지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().spUN >= 5)
        {
            this.maxIncrease = true;
        }

        // 두개의 조건이 충족하면 나온다
        if (this.uDirector.GetComponent<UpgradeDirector>().bPUN >= 1 || this.uDirector.GetComponent<UpgradeDirector>().tUN >= 1)
        {
            this.btn.SetActive(true);
        }
    }

    public void Increase()
    {
        // 업그레이드가 가능한만큼 주스가 있는지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().jucie >= 10)
        {
            if (maxIncrease == false)
            {
                this.uDirector.GetComponent<UpgradeDirector>().spUN += 1;        // 업그레이드 넘버를 가져와 늘린다

                this.uDirector.GetComponent<UpgradeDirector>().jucie -= 10;     // juice를 가져와 줄인다

                this.uDirector.GetComponent<UpgradeDirector>().span -= this.uDirector.GetComponent<UpgradeDirector>().span * 1.1f;      // 획득속도 줄이기

                PlayerPrefs.SetInt("jucie", this.uDirector.GetComponent<UpgradeDirector>().jucie);
                PlayerPrefs.SetFloat("span", this.uDirector.GetComponent<UpgradeDirector>().span);
                PlayerPrefs.SetInt("spUN", this.uDirector.GetComponent<UpgradeDirector>().spUN);
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
