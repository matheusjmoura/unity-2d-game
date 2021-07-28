using UnityEngine;

public class script_camera : MonoBehaviour
{

    public GameObject pc;
    public float i;
    public float j;
    
    void Start()
    {
        i = 2.7f;
        j =  -10;
    }
    
    void Update()
    {
        if (pc) {
            Vector3 pos = new Vector3(pc.transform.position.x, pc.transform.position.y + i, j);
            transform.position = pos;
        }
    }
}
