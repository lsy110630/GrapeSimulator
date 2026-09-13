using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCode : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.LoadScene("Title");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
