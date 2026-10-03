using UnityEngine;
public class GrapePrefab : MonoBehaviour
{
    GameObject director;
    AudioManager audioManager;
    float span = 3.0f;       // 사라질떄까지 시간
    float delta = 0;         // 시간재기
    bool one = true;         // 한번만 카운트

    private void Awake()
    {
        this.director = GameObject.Find("MainDirector");
        this.audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        this.span = this.director.GetComponent<MainGameDirector>().span;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 한번 서클과 닿았을떄 일정확률로 바로 부숴짐
        if ((one == true) && (collision.gameObject.tag == "Circle"))
        {
            one = false; // 여러번 발생하면 안되기 때문에 한 번만 발생할 수 있게 False로 바꾼다
            int dice = Random.Range(1, 1001);
            // 주사위 값이 바로 부숴지는 변수 값보다 낮을때
            if (dice <= this.director.GetComponent<MainGameDirector>().bP)
            {
                // 포도 얻고 경험치 증가
                this.director.GetComponent<MainGameDirector>().podo += this.director.GetComponent<MainGameDirector>().value;
                this.director.GetComponent<MainGameDirector>().EX += 1 + this.director.GetComponent<MainGameDirector>().addEX;

                int dice2 = Random.Range(1, 1001);
                // 주사위 값이 포도 생성 변수 값보다 낮을때
                if (dice2 <= this.director.GetComponent<MainGameDirector>().pSP)
                {
                    // 포도생성 함수실행
                    this.director.GetComponent<GrapeGenerator>().podoSpawn();
                }

                this.audioManager.podo();
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // 닿은 오브젝트가 원(범위)면
        if (collision.gameObject.tag == "Circle")
        {
            // 포도 애니메이션 작동
            this.GetComponent<Animator>().Play("GrapeAnimation");

            this.delta += Time.deltaTime;
            // 시간이 지나면 
            if (this.delta > span)
            {
                // 포도 얻고 경험치 증가
                this.director.GetComponent<MainGameDirector>().podo += this.director.GetComponent<MainGameDirector>().value;
                this.director.GetComponent<MainGameDirector>().EX += 1 + this.director.GetComponent<MainGameDirector>().addEX;

                int dice = Random.Range(1, 1001);
                // 주사위 값이 포도 생성 변수 값보다 낮을때
                if (dice <= this.director.GetComponent<MainGameDirector>().pSP)
                {
                    // 포도생성 함수실행
                    this.director.GetComponent<GrapeGenerator>().podoSpawn();
                }

                this.audioManager.podo();
                Destroy(this.gameObject); // 나 터짐
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        {
            // 포도 에니메이션 종료
            this.GetComponent<Animator>().Play("GrapeIdle");
        }
    }
}
