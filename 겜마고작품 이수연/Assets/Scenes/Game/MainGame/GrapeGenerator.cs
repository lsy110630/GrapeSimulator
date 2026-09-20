using UnityEngine;

public class GrapeGenerator : MonoBehaviour
{
    public int number;                   // 포도개수
    public GameObject grape;             // 포도를 담을 변수
    public GameObject goldgrape;         // 골드 포도
    public GameObject diamondgrape;      // 다이아 포도
    GameObject item;                     // 최종 스폰 옵젝

    // 아티팩트 넣을 변수
    public GameObject glovepodo;
    public GameObject scissorspodo;
    public GameObject hatpodo;
    public GameObject overallspodo;
    public GameObject shosepodo;

    GameObject mDirector;

    bool one = true;

    void Start()
    {
        this.mDirector = GameObject.Find("MainDirector");

        // 생성할 포도 개수 불러오기
        this.number = this.mDirector.GetComponent<MainGameDirector>().podoCount;

        // 포도를 30개 소환한다
        for (int i = 0; i < number; i++)
        {
            int dice = Random.Range(1, 1001);
            int gold = Random.Range(1, 101);
            int diamond = Random.Range(1, 101);

            // 한 번만 주사위 값이 아티팩트 소환 값보다 낮으면 아티팩트 소환
            if (dice <= this.mDirector.GetComponent<MainGameDirector>().artiP && one == true)
            {
                dice = Random.Range(1, 6);

                // 무한 반복
                while (true)
                {
                    // 주사위가 1이며 아티팩트에 글러브가 없으면 
                    if (dice == 1 && this.mDirector.GetComponent<MainGameDirector>().glovepodo == 0)
                    {
                        item = Instantiate(glovepodo);
                        break;
                    }

                    // 주사위가 2이며 아티팩트에 가위가 없으면 
                    if (dice == 2 && this.mDirector.GetComponent<MainGameDirector>().scissorspodo == 0)
                    {
                        item = Instantiate(scissorspodo);
                        break;
                    }

                    // 주사위가 3이며 아티팩트에 모자가 없으면 
                    if (dice == 3 && this.mDirector.GetComponent<MainGameDirector>().hatpodo == 0)
                    {
                        item = Instantiate(hatpodo);
                        break;
                    }

                    // 주사위가 4이며 아티팩트에 맬빵바지가 없으면 
                    if (dice == 4 && this.mDirector.GetComponent<MainGameDirector>().overallspodo == 0)
                    {
                        item = Instantiate(overallspodo);
                        break;
                    }

                    // 주사위가 5이며 아티팩트에 신발이 없으면 
                    if (dice == 5 && this.mDirector.GetComponent<MainGameDirector>().shosepodo == 0)
                    {
                        item = Instantiate(shosepodo);
                        break;
                    }
                }

                one = false;
            }

            // 골드 주사위가 확률 값보다 낮으면 골드 포도 소환
            else if (gold <= this.mDirector.GetComponent<MainGameDirector>().goldP)
            {
                item = Instantiate(goldgrape);
            }

            // 다이아 주사위가 확률 값보다 낮으면 다이아 포도 소환
            else if (diamond <= this.mDirector.GetComponent<MainGameDirector>().diamondP)
            {
                item = Instantiate(diamondgrape);
            }

            // 그냥 포도
            else
            {
                item = Instantiate(grape);
            }

            float x = Random.Range(-7.5f, 7.5f);
            float y = Random.Range(-3.5f, 3.5f);
            item.transform.position = new Vector3(x, y, 0);
        }
    }

    // 포도를 얻었을 때 일정 확률로 포도 소환할 함수
    public void podoSpawn()
    {
        int gold = Random.Range(1, 101);
        int diamond = Random.Range(1, 101);

        // 골드 주사위가 확률 값보다 낮으면 골드 포도 소환
        if (gold <= this.mDirector.GetComponent<MainGameDirector>().goldP)
        {
            item = Instantiate(goldgrape);
        }

        // 다이아 주사위가 확률 값보다 낮으면 다이아 포도 소환
        else if (diamond <= this.mDirector.GetComponent<MainGameDirector>().diamondP)
        {
            item = Instantiate(diamondgrape);
        }

        // 그냥 포도
        else
        {
            item = Instantiate(grape);
        }

        float x = Random.Range(-7.5f, 7.5f);
        float y = Random.Range(-3.5f, 3.5f);
        item.transform.position = new Vector3(x, y, 0);
    }
}
