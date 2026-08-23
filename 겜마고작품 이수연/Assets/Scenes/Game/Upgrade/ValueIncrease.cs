using UnityEngine;

public class ValueIncrease : MonoBehaviour
{
    GameObject uDirector;
    bool maxIncrease = false;   // 업그레이드 가능 판단

    void Start()
    {
        this.uDirector = GameObject.Find("UpgradeDirector");
    }

    void Update()
    {
        // 업그레이드가 최대치인지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().vUN >= 5)
        {
            this.maxIncrease = true;
        }
    }

    public void Increase()
    {
        // 업그레이드가 가능한만큼 주스가 있는지 판단
        if (this.uDirector.GetComponent<UpgradeDirector>().juice >= 30)
        {
            if (maxIncrease == false)
            {
                this.uDirector.GetComponent<UpgradeDirector>().vUN += 1;        // 업그레이드 넘버를 가져와 늘린다

                this.uDirector.GetComponent<UpgradeDirector>().juice -= 30;     // juice를 가져와 줄인다

                this.uDirector.GetComponent<UpgradeDirector>().value += 1;       // 포도 가치를 가져와 늘린다

                PlayerPrefs.SetInt("juice", this.uDirector.GetComponent<UpgradeDirector>().juice);
                PlayerPrefs.SetInt("value", this.uDirector.GetComponent<UpgradeDirector>().value);
                PlayerPrefs.SetInt("vUN", this.uDirector.GetComponent<UpgradeDirector>().tUN);

                PlayerPrefs.Save();
            }
        }
    }
}
