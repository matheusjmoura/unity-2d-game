using UnityEngine;

public class script_cenaController : MonoBehaviour
{
    
    private AudioSource som;
    
    void Start()
    {
        som = GetComponent<AudioSource>();
        som.Play();
    }
}
