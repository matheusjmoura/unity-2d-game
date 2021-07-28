using UnityEngine;
using UnityEngine.SceneManagement;

public class script_portaFinal : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
