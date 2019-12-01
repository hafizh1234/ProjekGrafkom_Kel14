using UnityEngine;
using System.Collections;

public class movecam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>(). velocity = new Vector3 (0, tangga.vertVel, 4*tangga.zVelAdj);
    }
}
