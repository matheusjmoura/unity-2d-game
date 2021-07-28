using UnityEngine;
using UnityEngine.SceneManagement;

public class script_lava : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
    }
}
