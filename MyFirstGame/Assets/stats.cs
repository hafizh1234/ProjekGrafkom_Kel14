using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (gameObject.name ==  "cointext") {
        GetComponent<TextMesh>().text = "Score : " + tangga.coinTotal;
        }
        if (gameObject.name ==  "timetext") {
        GetComponent<TextMesh>().text = "Waktu : " + (int)tangga.timeTotal +" detik";
        }
        if (gameObject.name ==  "runstatus") {
        GetComponent<TextMesh>().text = tangga.GameProses2;
        }
    }
}
