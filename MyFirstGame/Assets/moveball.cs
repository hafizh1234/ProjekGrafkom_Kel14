using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class moveball : MonoBehaviour {

    public KeyCode moveL;
    public KeyCode moveR;

    // public GameObject ball;

    public float horizVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";
    public static float posisis;

    public Transform boomObj;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody> (). velocity = new Vector3 (horizVel, tangga.vertVel, 4);


        if  ((Input.GetKeyDown (moveL)) && (laneNum>1) && (controlLocked == "n"))
        {
            horizVel = -2;
            StartCoroutine (stopSlide ());
            laneNum -= 1;
            controlLocked = "y";
        }

        posisis=this.transform.position.z;
        
        if ((Input.GetKeyDown (moveR)) && (laneNum<3) && (controlLocked == "n"))
        {
            horizVel = 2;
            StartCoroutine (stopSlide ());
             laneNum += 1;
             controlLocked = "y";
        }

        //testing
      }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "lethal")
            {
                Destroy (gameObject);
                tangga.zVelAdj=0;
                Instantiate(boomObj, transform.position,boomObj.rotation);
                tangga.GameProses2="Fail"; 
            
            }
            if (other.gameObject.name == "Capsule")
            {
                Destroy (other.gameObject);
                
            }
    }
    void OnTriggerEnter(Collider other) {

        if (other.gameObject.name == "ramtrig")
        {
            tangga.vertVel= 2;
        }

        if (other.gameObject.name == "ramtring1")
        {
            tangga.vertVel= 0;
        }

        if (other.gameObject.name == "exit") {
            
            tangga.GameProses2 = "Success !!";
            SceneManager.LoadScene("Game Proses 2");
        }

         if (other.gameObject.name == "coin") {
                
           Destroy(other.gameObject);
           tangga.coinTotal += 1;
        }
        if (other.gameObject.name == "coin(Clone)") {
                
           Destroy(other.gameObject);
           tangga.coinTotal += 1;
        }


    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds (.5f);
        horizVel = 0;
        controlLocked = "n";
    }
}
