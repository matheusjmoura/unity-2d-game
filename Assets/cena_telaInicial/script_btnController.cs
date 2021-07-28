using UnityEngine;
using UnityEngine.SceneManagement;

public class script_btnController : MonoBehaviour
{

    private AudioSource som;

    public void iniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void sair()
    {
        Application.Quit();
    }

    void Start()
    {
        som = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            som.Play();
        }
    }
}
