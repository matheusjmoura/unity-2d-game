using UnityEngine;

public class script_btnSelecionar : MonoBehaviour
{
    
    private AudioSource som;
    
	void Start () {
        som = GetComponent<AudioSource>();
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
            som.Play();
	}
}
