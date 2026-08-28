using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject mDirector;

    public float speed = 0.03f;

    private void Awake()
    {
        this.mDirector = GameObject.Find("MainDirector");

        this.speed = PlayerPrefs.GetFloat("speed", 0.03f);
    }

    void Update()
    {
        //  wasd를 눌렀을때 플레이어가 움직인다
        if (Input.GetKey(KeyCode.W) && this.transform.position.y < 4)
        {
            this.transform.Translate(0, speed, 0);
        }

        if (Input.GetKey(KeyCode.S) && this.transform.position.y > -4)
        {
            this.transform.Translate(0, -speed, 0);
        }

        if (Input.GetKey(KeyCode.A) && this.transform.position.x > -8)
        {
            this.transform.Translate(-speed, 0, 0);
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey(KeyCode.D) && this.transform.position.x < 8)
        {
            this.transform.Translate(speed, 0, 0);
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
