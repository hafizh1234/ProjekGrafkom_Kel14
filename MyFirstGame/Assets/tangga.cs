﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class tangga : MonoBehaviour {
    public static float vertVel=0;
    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public static int timet=0;
    public static float waittoload = 0;
    public static float zVelAdj = 1;
    public static string GameProses2= "";
    public static float wktpwrp=0;
    public Transform bbNoPit;
    public Transform bbPitMid;
    public float titikt=344;
    public string titiktm4="";
    public string titiktm3="";
    public string titiktm2="";
    public string titiktm1="";
    public float titiktd=344;
    public string letakkoin="";
    public int RandM;



    public Transform coinObj;
    public Transform balokteghObj;
    public Transform capsuleK;
    public Transform balokgd;

    public int randN;
    public int randt;
    public int rand;
    public float zScenePos= 44;

    public void rintangan1(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    public void rintangan2(){
        int i;
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
   
    }

    
    public void rintangan3(){
        int i;
        //kirikiritengahkiri
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
   
    
    public void rintangan4(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }

    public void rintangan5(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
    }
 
    public void rintangan6(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
    }

    public void rintangan7(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }

    public void rintangan8(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }

    public void rintangan9(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }

    public void rintangan10(){
        int i;
        //kirikirikiritengah 
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }

    public void rintangan11(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
 
    public void rintangan12(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }

    public void rintangan13(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
    
    public void rintangan14(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    public void rintangan15(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }
    
    public void rintangan16(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    public void rintangan17(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }
    
    public void rintangan18(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
    
    public void rintangan19(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt),balokgd.rotation);
            titiktm1="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }

     public void rintangan20(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    public void rintangan21(){
        int i;
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
   
    }

    
    public void rintangan22(){
        int i;
        //kirikiritengahkiri
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
   
    
    public void rintangan23(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }

    public void rintangan24(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
    }
 
    public void rintangan25(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
    }

    public void rintangan26(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }

    public void rintangan27(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }

    public void rintangan28(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }

    public void rintangan29(){
        int i;
        //kirikirikiritengah 
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }

    public void rintangan30(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
 
    public void rintangan31(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }

    public void rintangan32(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
    
    public void rintangan33(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    public void rintangan34(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }
    
    public void rintangan35(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
    
    public void rintangan36(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    public void rintangan37(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }
    
    public void rintangan38(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
     public void rintangan39(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }

     public void rintangan40(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
    
    public void rintangan41(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt),balokteghObj.rotation);
            titiktm1="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(0,2.88f,titikt),balokgd.rotation);
            titiktm1="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }

    public void rintangan42(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    public void rintangan43(){
        int i;
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
   
    }

    
    public void rintangan44(){
        int i;
        //kirikiritengahkiri
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
   
    
    public void rintangan45(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }

    public void rintangan46(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
    }
 
    public void rintangan47(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
    }

    public void rintangan48(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }

    public void rintangan49(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";

        }
        
    }

    public void rintangan50(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }

    public void rintangan51(){
        int i;
        //kirikirikiritengah 
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
           
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            

        }
        
    }

    public void rintangan52(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
           
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            

        }
        
    }
 
    public void rintangan53(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+2),balokgd.rotation);
            titiktm2="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }

    public void rintangan54(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
    
    public void rintangan55(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    public void rintangan56(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kiri";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kiri";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }
    
    public void rintangan57(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    public void rintangan58(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="tengah";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kanan";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+4),balokgd.rotation);
            titiktm3="tengah";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kanan";

        }
        
    }
    
    public void rintangan59(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="kiri";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(-1,2.88f,titikt+6),balokgd.rotation);
            titiktm4="kiri";

        }
        
    }
    
    public void rintangan60(){
        int i;
        //kirikirikiritengah
        if(rand%2==0){
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt),balokteghObj.rotation);
            titiktm1="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
            titiktm2="kanan";
            Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+4),balokteghObj.rotation);
            titiktm3="kanan";
            Instantiate(balokteghObj,new Vector3(0,2.88f,titikt+6),balokteghObj.rotation);
            titiktm4="tengah";
        }
        else{
            Instantiate(balokgd,new Vector3(1,2.88f,titikt),balokgd.rotation);
            titiktm1="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+2),balokgd.rotation);
            titiktm2="kanan";
            Instantiate(balokgd,new Vector3(1,2.88f,titikt+4),balokgd.rotation);
            titiktm3="kanan";
            Instantiate(balokgd,new Vector3(0,2.88f,titikt+6),balokgd.rotation);
            titiktm4="tengah";

        }
        
    }
    
    
    
    // Start is called before the first frame update
    void Start() {
        Instantiate(bbNoPit, new Vector3(0,1.9f,36),bbNoPit.rotation);
        Instantiate(bbNoPit, new Vector3(0,1.9f,40),bbNoPit.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameProses2!="Fail"){
            if(moveball.posisis>=titikt-40){
                RandM=Random.Range(1,60);
                randt=Random.Range(0,2);
                rand=Random.Range(0,15);
                randN=Random.Range(0,17);

            /*Instantiate(bbNoPit, new Vector3(0,1.9f,titikt),bbNoPit.rotation);
            Instantiate(bbNoPit, new Vector3(0,1.9f,titikt+4),bbNoPit.rotation);
            rintangan21();
            Instantiate(coinObj, new Vector3(-1,3.08f,titikt),coinObj.rotation);
            Instantiate(coinObj, new Vector3(0,3.08f,titikt+2),coinObj.rotation);
            Instantiate(coinObj, new Vector3(0,3.08f,titikt+4),coinObj.rotation);
            Instantiate(coinObj, new Vector3(-1,3.08f,titikt+4),coinObj.rotation);
            if(titikt==titiktd){
                titiktd=titikt-2;
            }*/

                if(titikt!=titiktd){
                    Instantiate(bbNoPit, new Vector3(0,1.9f,titikt),bbNoPit.rotation);
                    Instantiate(bbNoPit, new Vector3(0,1.9f,titikt+4),bbNoPit.rotation);

                    /*if(titiktm4=="kanan"){
                        if(RandM==1)rintangan1();
                        else if(RandM==2)rintangan2();
                        else if(RandM==3)rintangan3();
                        else if(RandM==4)rintangan4();
                        else if(RandM==5)rintangan5();
                        else if(RandM==6)rintangan6();
                        else if(RandM==7)rintangan7();
                        else if(RandM==8)rintangan8();
                        else if(RandM==9)rintangan9();                
                        else if(RandM==10)rintangan10();
                        else if(RandM==11)rintangan11();
                        else if(RandM==12)rintangan12();
                        else if(RandM==13)rintangan13();
                        else if(RandM==14)rintangan14();
                        else if(RandM==15)rintangan15();
                        else if(RandM==16)rintangan16();
                        else if(RandM==17)rintangan17();
                        else if(RandM==18)rintangan18();
                        else if(RandM==19)rintangan19();
                        else if(RandM==20)rintangan20();
                        else if(RandM==21)rintangan21();
                        else if(RandM==22)rintangan22();
                        else if(RandM==23)rintangan23();
                        else if(RandM==24)rintangan24();
                        else if(RandM==25)rintangan25();                
                        else if(RandM==26)rintangan26();
                        else if(RandM==27)rintangan27();
                        else if(RandM==28)rintangan28();
                        else if(RandM==29)rintangan29();
                        else if(RandM==30)rintangan30();
                        else if(RandM==31)rintangan31();
                        else if(RandM==32)rintangan32();
                        else if(RandM==33)rintangan33();
                        else if(RandM==34)rintangan34();
                        else if(RandM==35)rintangan35();
                        else if(RandM==36)rintangan36();
                        else if(RandM==37)rintangan37();
                        else if(RandM==38)rintangan38();
                        else if(RandM==39)rintangan39();
                        else if(RandM==40)rintangan40();
                        else if(RandM==41)rintangan41();                 
            
                    }

                    else if(titiktm4=="tengah"){
                        if(RandM==1)rintangan1();
                        else if(RandM==2)rintangan2();
                        else if(RandM==3)rintangan3();
                        else if(RandM==4)rintangan4();
                        else if(RandM==5)rintangan5();
                        else if(RandM==6)rintangan6();
                        else if(RandM==7)rintangan7();
                        else if(RandM==8)rintangan8();
                        else if(RandM==9)rintangan9();                
                        else if(RandM==10)rintangan10();
                        else if(RandM==11)rintangan11();
                        else if(RandM==12)rintangan12();
                        else if(RandM==13)rintangan13();
                        else if(RandM==14)rintangan14();
                        else if(RandM==15)rintangan15();
                        else if(RandM==16)rintangan16();
                        else if(RandM==17)rintangan17();
                        else if(RandM==18)rintangan18();
                        else if(RandM==19)rintangan19();
                        else if(RandM==42)rintangan42();
                        else if(RandM==43)rintangan43();
                        else if(RandM==44)rintangan44();
                        else if(RandM==45)rintangan45();
                        else if(RandM==46)rintangan46();
                        else if(RandM==47)rintangan47();
                        else if(RandM==48)rintangan48();
                        else if(RandM==49)rintangan49();
                        else if(RandM==50)rintangan50();                
                        else if(RandM==51)rintangan51();
                        else if(RandM==52)rintangan52();
                        else if(RandM==53)rintangan53();
                        else if(RandM==54)rintangan54();
                        else if(RandM==55)rintangan55();
                        else if(RandM==56)rintangan56();
                        else if(RandM==57)rintangan57();
                        else if(RandM==58)rintangan58();
                        else if(RandM==59)rintangan59();
                        else if(RandM==60)rintangan60();
                    }

                    if(titiktm4=="kiri"){
                        if(RandM==20)rintangan20();
                        else if(RandM==21)rintangan21();
                        else if(RandM==22)rintangan22();
                        else if(RandM==23)rintangan23();
                        else if(RandM==24)rintangan24();
                        else if(RandM==25)rintangan25();                
                        else if(RandM==26)rintangan26();
                        else if(RandM==27)rintangan27();
                        else if(RandM==28)rintangan28();
                        else if(RandM==29)rintangan29();
                        else if(RandM==30)rintangan30();
                        else if(RandM==31)rintangan31();
                        else if(RandM==32)rintangan32();
                        else if(RandM==33)rintangan33();
                        else if(RandM==34)rintangan34();
                        else if(RandM==35)rintangan35();
                        else if(RandM==36)rintangan36();
                        else if(RandM==37)rintangan37();
                        else if(RandM==38)rintangan38();
                        else if(RandM==39)rintangan39();
                        else if(RandM==40)rintangan40();
                        else if(RandM==41)rintangan41(); 
                        else if(RandM==42)rintangan42();
                        else if(RandM==43)rintangan43();
                        else if(RandM==44)rintangan44();
                        else if(RandM==45)rintangan45();
                        else if(RandM==46)rintangan46();
                        else if(RandM==47)rintangan47();
                        else if(RandM==48)rintangan48();
                        else if(RandM==49)rintangan49();
                        else if(RandM==50)rintangan50();                
                        else if(RandM==51)rintangan51();
                        else if(RandM==52)rintangan52();
                        else if(RandM==53)rintangan53();
                        else if(RandM==54)rintangan54();
                        else if(RandM==55)rintangan55();
                        else if(RandM==56)rintangan56();
                        else if(RandM==57)rintangan57();
                        else if(RandM==58)rintangan58();
                        else if(RandM==59)rintangan59();
                        else if(RandM==60)rintangan60();
                    }

                    titiktd=titikt;

                    if(titiktm1=="kiri"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt),coinObj.rotation);
                        if((titikt-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt),capsuleK.rotation);
                        }
                    }

                    else if(titiktm1=="tengah"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt),coinObj.rotation);
                        if(rand%2==0&&(titikt-344)%50==0){
                            Instantiate(capsuleK,new Vector3(-1,2.88f,titikt),capsuleK.rotation);
                        }
                        else if(rand%2==1&&(titikt-344)%50==0){
                            Instantiate(capsuleK,new Vector3(1,2.88f,titikt),capsuleK.rotation);
                        }
                        
                    }
            
                    else if(titiktm1=="kanan"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt),coinObj.rotation);
                        if((titikt-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2-1,2.88f,titikt),capsuleK.rotation);
                        }
                        
                    }

                    if(titiktm2=="kiri"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+2),coinObj.rotation);
                        if((titikt+2-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt+2),capsuleK.rotation);
                        }
                    }

                    else if(titiktm2=="tengah"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+2),coinObj.rotation);
                        if(rand%2==0&&(titikt+2-344)%50==0){
                            Instantiate(capsuleK,new Vector3(-1,2.88f,titikt+2),capsuleK.rotation);
                        }
                        else if(rand%2==1&&(titikt+2-344)%50==0){
                            Instantiate(capsuleK,new Vector3(1,2.88f,titikt+2),capsuleK.rotation);
                        }
                        
                    }
            
                    else if(titiktm2=="kanan"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+2),coinObj.rotation);
                        if((titikt+2-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2-1,2.88f,titikt+2),capsuleK.rotation);
                        }
                        
                    }
             
                    if(titiktm3=="kiri"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+4),coinObj.rotation);
                        if((titikt+4-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt+4),capsuleK.rotation);
                        }
                    }

                    else if(titiktm3=="tengah"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+4),coinObj.rotation);
                        if(rand%2==0&&(titikt+4-344)%50==0){
                            Instantiate(capsuleK,new Vector3(-1,2.88f,titikt+4),capsuleK.rotation);
                        }
                        else if(rand%2==1&&(titikt+4-344)%50==0){
                            Instantiate(capsuleK,new Vector3(1,2.88f,titikt+4),capsuleK.rotation);
                        }
                        
                    }
            
                    else if(titiktm3=="kanan"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+4),coinObj.rotation);
                        if((titikt+4-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2-1,2.88f,titikt+4),capsuleK.rotation);
                        }
                        
                    }

                    if(titiktm4=="kiri"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+6),coinObj.rotation);
                        if((titikt+6-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt+6),capsuleK.rotation);
                        }
                    }

                    else if(titiktm4=="tengah"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+6),coinObj.rotation);
                        if(rand%2==0&&(titikt+6-344)%50==0){
                            Instantiate(capsuleK,new Vector3(-1,2.88f,titikt+6),capsuleK.rotation);
                        }
                        else if(rand%2==1&&(titikt+6-344)%50==0){
                            Instantiate(capsuleK,new Vector3(1,2.88f,titikt+6),capsuleK.rotation);
                        }
                        
                    }
            
                    else if(titiktm4=="kanan"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+6),coinObj.rotation);
                        if((titikt+6-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2-1,2.88f,titikt+6),capsuleK.rotation);
                        }
                        
                    }
             
                    Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+8),coinObj.rotation);
                        if((titikt+8-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt+8),capsuleK.rotation);
                        }
                    titikt=titikt+10;
                    titiktd=titikt-2;
            
                }*/


                
                    if(titiktm1=="kiri"&&titiktm2=="tengah"){ 
                        if(randN%3==0){
                            Instantiate(coinObj, new Vector3(-1,3.08f,titikt),coinObj.rotation);
                            Instantiate(balokteghObj, new Vector3(0,2.88f,titikt),balokteghObj.rotation);
                                titiktm3="tengah";
                            }

                        else if(randN%3==1){
                            Instantiate(coinObj, new Vector3(0,3.08f,titikt),coinObj.rotation);
                            Instantiate(balokteghObj, new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
                                titiktm3="kiri";
                            }
                        
                        else if(randN%3==2){
                            Instantiate(coinObj, new Vector3(1,3.08f,titikt),coinObj.rotation);
                            if(rand%2==0){
                                Instantiate(balokteghObj, new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
                                titiktm3="kiri";
                            }
                            else if(rand%2==1){
                                Instantiate(balokteghObj, new Vector3(0,2.88f,titikt),balokteghObj.rotation);
                                titiktm3="tengah";
                            }
                        }
                    }

                    else if(titiktm1=="kanan"&&titiktm2=="tengah"){
                        
                        if(randN%3==0){
                            Instantiate(coinObj, new Vector3(-1,3.08f,titikt),coinObj.rotation);
                            if(rand%2==0){
                                Instantiate(balokteghObj, new Vector3(0,2.88f,titikt),balokteghObj.rotation);
                                titiktm3="tengah";
                            }
                            else if(rand%2==1){
                                Instantiate(balokteghObj, new Vector3(1,2.88f,titikt),balokteghObj.rotation);
                                titiktm3="kanan";
                            }
                        }
                        else if(randN%3==1){
                            Instantiate(coinObj, new Vector3(0,3.08f,titikt),coinObj.rotation);
                            Instantiate(balokteghObj, new Vector3(1,2.88f,titikt),balokteghObj.rotation);
                                titiktm3="kanan";
                            }
                        
                        else if(randN%3==2){
                            Instantiate(coinObj, new Vector3(1,3.08f,titikt),coinObj.rotation);
                            Instantiate(balokteghObj, new Vector3(0,2.88f,titikt),balokteghObj.rotation);
                                titiktm3="tengah";
                        }
                    }
                    
                    else if(titiktm1=="tengah "&&titiktm2=="tengah"){
                        
                        Instantiate(coinObj, new Vector3(0,3.08f,titikt),coinObj.rotation);
                        letakkoin="tengah";
                        if(rand%2==0){
                            Instantiate(balokteghObj, new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
                            titiktm3="kiri";
                        }
                        else if(rand%2==1){
                            Instantiate(balokteghObj, new Vector3(1,2.88f,titikt),balokteghObj.rotation);
                            titiktm3="kanan";
                        }
                    }
                    
                    else if(randN%3==0){
                        Instantiate(coinObj, new Vector3(-1,3.08f,titikt),coinObj.rotation);
                    
                        if(rand%3==1){
                            Instantiate(balokteghObj, new Vector3(0,2.88f,titikt),balokteghObj.rotation);
                            titiktm3="tengah";
                        }
                        else if(rand%3==2){
                            Instantiate(balokteghObj, new Vector3(1,2.88f,titikt),balokteghObj.rotation);
                            titiktm3="kanan";
                        }
                        else{
                            titiktm3="";
                        }
                    }
                    
                    else if(randN%3==2){
                        Instantiate(coinObj, new Vector3(1,3.08f,titikt),coinObj.rotation);
                        if(rand%3==0){
                            Instantiate(balokteghObj, new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
                            titiktm3="kiri";
                        }
                        else if(rand%3==1){
                            Instantiate(balokteghObj, new Vector3(0,2.88f,titikt),balokteghObj.rotation);
                            titiktm3="tengah";
                        }
                        else{
                            titiktm3="";
                        }
                    } 

                    else if(randN%3==1){
                        Instantiate(coinObj, new Vector3(0,3.08f,titikt),coinObj.rotation);
                        if(rand%3==0){
                            Instantiate(balokteghObj, new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
                            titiktm3="kiri";
                        }
                        else if(rand%3==1){
                            Instantiate(balokteghObj, new Vector3(1,2.88f,titikt),balokteghObj.rotation);
                            titiktm3="kanan";
                        }
                        else{
                            titiktm3="";
                        }
                    }
                    
                    if(titiktm1=="kiri"&&titiktm2=="tengah"&&titiktm3=="tengah"){
                        if(rand%3==0){
                            Instantiate(coinObj, new Vector3(1,3.08f,titikt+2),coinObj.rotation);
                            letakkoin="kanan";
                            }
                        else if(rand%3==1){
                            Instantiate(coinObj, new Vector3(0,3.08f,titikt+2),coinObj.rotation);
                            letakkoin="tengah";
                            }
                        Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
                        titiktm1=titiktm2;
                        titiktm2=titiktm3;
                        titiktm3="kiri";
                    }

                    else if(titiktm1=="kanan"&&titiktm2=="tengah"&&titiktm3=="tengah"){
                        if(rand%3==0){
                            Instantiate(coinObj, new Vector3(-1,3.08f,titikt+2),coinObj.rotation);
                            letakkoin="kiri";
                            }
                        else if(rand%3==1){
                            Instantiate(coinObj, new Vector3(0,3.08f,titikt+2),coinObj.rotation);
                            letakkoin="tengah";
                            }
                        Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
                        titiktm1=titiktm2;
                        titiktm2=titiktm3;
                        titiktm3="kanan";
                    }


                    else{    
                        if(rand%3==0){
                            Instantiate(coinObj, new Vector3(randt-1,3.08f,titikt+2),coinObj.rotation);
                            letakkoin="kiri";
                            titiktm1=titiktm2;
                            titiktm2=titiktm3;
                            titiktm3="";
                
                            }
                        else if(rand%3==1){
                            Instantiate(balokteghObj, new Vector3(randt-1,2.88f,titikt+2),balokteghObj.rotation);
                            if(randt-1==-1){
                                titiktm1=titiktm2;
                                titiktm2=titiktm3;
                                titiktm3="kiri";
                            }
                            else if(randt-1==0){
                                titiktm1=titiktm2;
                                titiktm2=titiktm3;
                                titiktm3="tengah";
                            }
                            else if(randt-1==1){
                                titiktm1=titiktm2;
                                titiktm2=titiktm3;
                                titiktm3="kanan";
                            }
                        }
                        else if(rand%3==2){
                            Instantiate(balokgd, new Vector3(randt-1,2.88f,titikt+2),balokgd.rotation);
                            if(randt-1==-1){
                                titiktm1=titiktm2;
                                titiktm2=titiktm3;
                                titiktm3="kiri";
                
                            }
                            else if(randt-1==0){
                                titiktm1=titiktm2;
                                titiktm2=titiktm3;
                                titiktm3="tengah";
                
                            }
                            else if(randt-1==1){
                                titiktm1=titiktm2;
                                titiktm2=titiktm3;
                                titiktm3="kanan";
                            }
                        }
                    }
                    
                    if((titikt-344)%50==0){
                        if(letakkoin=="tengah"&&titiktm3=="kiri"){
                             Instantiate(capsuleK,new Vector3(1,2.88f,titikt),capsuleK.rotation);
                        }
                        else if(letakkoin=="tengah"&&titiktm3=="kanan"){
                             Instantiate(capsuleK,new Vector3(-1,2.88f,titikt),capsuleK.rotation);
                        }
                        else if(letakkoin=="kiri"&&titiktm3=="kanan"){
                             Instantiate(capsuleK,new Vector3(0,2.88f,titikt),capsuleK.rotation);
                        }
                        else if(letakkoin=="kiri"&&titiktm3=="tengah"){
                             Instantiate(capsuleK,new Vector3(1,2.88f,titikt),capsuleK.rotation);
                        }
                        else if(letakkoin=="kanan"&&titiktm3=="kiri"){
                             Instantiate(capsuleK,new Vector3(0,2.88f,titikt),capsuleK.rotation);
                        }
                        else if(letakkoin=="kanan"&&titiktm3=="tengah"){
                             Instantiate(capsuleK,new Vector3(0,2.88f,titikt),capsuleK.rotation);
                        }
                        else{
                             Instantiate(capsuleK,new Vector3(randt-1,2.88f,titikt),capsuleK.rotation);
                        }
                    }
                    
                    titiktm1=titiktm2;
                    titiktm2=titiktm3;
                    titiktm3="";
                    
                    titiktd=titikt;
                    titikt+=4;
                }
            
             
            
                
                else if(titikt==titiktd){
                    Instantiate(bbNoPit, new Vector3(0,1.9f,titikt),bbNoPit.rotation);
                    Instantiate(bbNoPit, new Vector3(0,1.9f,titikt+4),bbNoPit.rotation);

                /*    if(titiktm4=="kanan"){
                        if(RandM==1)rintangan1();
                        else if(RandM==2)rintangan2();
                        else if(RandM==3)rintangan3();
                        else if(RandM==4)rintangan4();
                        else if(RandM==5)rintangan5();
                        else if(RandM==6)rintangan6();
                        else if(RandM==7)rintangan7();
                        else if(RandM==8)rintangan8();
                        else if(RandM==9)rintangan9();                
                        else if(RandM==10)rintangan10();
                        else if(RandM==11)rintangan11();
                        else if(RandM==12)rintangan12();
                        else if(RandM==13)rintangan13();
                        else if(RandM==14)rintangan14();
                        else if(RandM==15)rintangan15();
                        else if(RandM==16)rintangan16();
                        else if(RandM==17)rintangan17();
                        else if(RandM==18)rintangan18();
                        else if(RandM==19)rintangan19();
                        else if(RandM==20)rintangan20();
                        else if(RandM==21)rintangan21();
                        else if(RandM==22)rintangan22();
                        else if(RandM==23)rintangan23();
                        else if(RandM==24)rintangan24();
                        else if(RandM==25)rintangan25();                
                        else if(RandM==26)rintangan26();
                        else if(RandM==27)rintangan27();
                        else if(RandM==28)rintangan28();
                        else if(RandM==29)rintangan29();
                        else if(RandM==30)rintangan30();
                        else if(RandM==31)rintangan31();
                        else if(RandM==32)rintangan32();
                        else if(RandM==33)rintangan33();
                        else if(RandM==34)rintangan34();
                        else if(RandM==35)rintangan35();
                        else if(RandM==36)rintangan36();
                        else if(RandM==37)rintangan37();
                        else if(RandM==38)rintangan38();
                        else if(RandM==39)rintangan39();
                        else if(RandM==40)rintangan40();
                        else if(RandM==41)rintangan41();                 
        
                    }

                    else if(titiktm4=="tengah"){
                        if(RandM==1)rintangan1();
                        else if(RandM==2)rintangan2();
                        else if(RandM==3)rintangan3();
                        else if(RandM==4)rintangan4();
                        else if(RandM==5)rintangan5();
                        else if(RandM==6)rintangan6();
                        else if(RandM==7)rintangan7();
                        else if(RandM==8)rintangan8();
                        else if(RandM==9)rintangan9();                
                        else if(RandM==10)rintangan10();
                        else if(RandM==11)rintangan11();
                        else if(RandM==12)rintangan12();
                        else if(RandM==13)rintangan13();
                        else if(RandM==14)rintangan14();
                        else if(RandM==15)rintangan15();
                        else if(RandM==16)rintangan16();
                        else if(RandM==17)rintangan17();
                        else if(RandM==18)rintangan18();
                        else if(RandM==19)rintangan19();
                        else if(RandM==42)rintangan42();
                        else if(RandM==43)rintangan43();
                        else if(RandM==44)rintangan44();
                        else if(RandM==45)rintangan45();
                        else if(RandM==46)rintangan46();
                        else if(RandM==47)rintangan47();
                        else if(RandM==48)rintangan48();
                        else if(RandM==49)rintangan49();
                        else if(RandM==50)rintangan50();                
                        else if(RandM==51)rintangan51();
                        else if(RandM==52)rintangan52();
                        else if(RandM==53)rintangan53();
                        else if(RandM==54)rintangan54();
                        else if(RandM==55)rintangan55();
                        else if(RandM==56)rintangan56();
                        else if(RandM==57)rintangan57();
                        else if(RandM==58)rintangan58();
                        else if(RandM==59)rintangan59();
                        else if(RandM==60)rintangan60();
                    }

                    if(titiktm4=="kiri"){
                        if(RandM==20)rintangan20();
                        else if(RandM==21)rintangan21();
                        else if(RandM==22)rintangan22();
                        else if(RandM==23)rintangan23();
                        else if(RandM==24)rintangan24();
                        else if(RandM==25)rintangan25();                
                        else if(RandM==26)rintangan26();
                        else if(RandM==27)rintangan27();
                        else if(RandM==28)rintangan28();
                        else if(RandM==29)rintangan29();
                        else if(RandM==30)rintangan30();
                        else if(RandM==31)rintangan31();
                        else if(RandM==32)rintangan32();
                        else if(RandM==33)rintangan33();
                        else if(RandM==34)rintangan34();
                        else if(RandM==35)rintangan35();
                        else if(RandM==36)rintangan36();
                        else if(RandM==37)rintangan37();
                        else if(RandM==38)rintangan38();
                        else if(RandM==39)rintangan39();
                        else if(RandM==40)rintangan40();
                        else if(RandM==41)rintangan41(); 
                        else if(RandM==42)rintangan42();
                        else if(RandM==43)rintangan43();
                        else if(RandM==44)rintangan44();
                        else if(RandM==45)rintangan45();
                        else if(RandM==46)rintangan46();
                        else if(RandM==47)rintangan47();
                        else if(RandM==48)rintangan48();
                        else if(RandM==49)rintangan49();
                        else if(RandM==50)rintangan50();                
                        else if(RandM==51)rintangan51();
                        else if(RandM==52)rintangan52();
                        else if(RandM==53)rintangan53();
                        else if(RandM==54)rintangan54();
                        else if(RandM==55)rintangan55();
                        else if(RandM==56)rintangan56();
                        else if(RandM==57)rintangan57();
                        else if(RandM==58)rintangan58();
                        else if(RandM==59)rintangan59();
                        else if(RandM==60)rintangan60();
                    }

                    titiktd=titikt;

                    Instantiate(bbNoPit, new Vector3(0,1.9f,titikt+8),bbNoPit.rotation);

                    if(titiktm1=="kiri"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt),coinObj.rotation);
                        if((titikt-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt),capsuleK.rotation);
                        }
                    }

                    else if(titiktm1=="tengah"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt),coinObj.rotation);
                        if(rand%2==0&&(titikt-344)%50==0){
                            Instantiate(capsuleK,new Vector3(-1,2.88f,titikt),capsuleK.rotation);
                        }
                        else if(rand%2==1&&(titikt-344)%50==0){
                            Instantiate(capsuleK,new Vector3(1,2.88f,titikt),capsuleK.rotation);
                        }
                        
                    }
            
                    else if(titiktm1=="kanan"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt),coinObj.rotation);
                        if((titikt-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2-1,2.88f,titikt),capsuleK.rotation);
                        }
                        
                    }

                    if(titiktm2=="kiri"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+2),coinObj.rotation);
                        if((titikt+2-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt+2),capsuleK.rotation);
                        }
                    }

                    else if(titiktm2=="tengah"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+2),coinObj.rotation);
                        if(rand%2==0&&(titikt+2-344)%50==0){
                            Instantiate(capsuleK,new Vector3(-1,2.88f,titikt+2),capsuleK.rotation);
                        }
                        else if(rand%2==1&&(titikt+2-344)%50==0){
                            Instantiate(capsuleK,new Vector3(1,2.88f,titikt+2),capsuleK.rotation);
                        }
                        
                    }
            
                    else if(titiktm2=="kanan"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+2),coinObj.rotation);
                        if((titikt+2-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2-1,2.88f,titikt+2),capsuleK.rotation);
                        }
                        
                    }
             
                    if(titiktm3=="kiri"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+4),coinObj.rotation);
                        if((titikt+4-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt+4),capsuleK.rotation);
                        }
                    }

                    else if(titiktm3=="tengah"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+4),coinObj.rotation);
                        if(rand%2==0&&(titikt+4-344)%50==0){
                            Instantiate(capsuleK,new Vector3(-1,2.88f,titikt+4),capsuleK.rotation);
                        }
                        else if(rand%2==1&&(titikt+4-344)%50==0){
                            Instantiate(capsuleK,new Vector3(1,2.88f,titikt+4),capsuleK.rotation);
                        }
                        
                    }
            
                    else if(titiktm3=="kanan"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+4),coinObj.rotation);
                        if((titikt+4-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2-1,2.88f,titikt+4),capsuleK.rotation);
                        }
                        
                    }

                    if(titiktm4=="kiri"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+6),coinObj.rotation);
                        if((titikt+6-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt+6),capsuleK.rotation);
                        }
                    }

                    else if(titiktm4=="tengah"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+6),coinObj.rotation);
                        if(rand%2==0&&(titikt+6-344)%50==0){
                            Instantiate(capsuleK,new Vector3(-1,2.88f,titikt+6),capsuleK.rotation);
                        }
                        else if(rand%2==1&&(titikt+6-344)%50==0){
                            Instantiate(capsuleK,new Vector3(1,2.88f,titikt+6),capsuleK.rotation);
                        }
                        
                    }
            
                    else if(titiktm4=="kanan"){
                        Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+6),coinObj.rotation);
                        if((titikt+6-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2-1,2.88f,titikt+6),capsuleK.rotation);
                        }
                        
                    }
             
                    Instantiate(coinObj,new Vector3(randt-1,3.08f,titikt+8),coinObj.rotation);
                        if((titikt+8-344)%50==0){
                            Instantiate(capsuleK,new Vector3(rand%2+1,2.88f,titikt+8),capsuleK.rotation);
                        }
                
                    titikt=titikt+10; 
                    titiktd=titikt;
            
                }*/

                    if(randN%3==0){
                        Instantiate(coinObj, new Vector3(-1,3.08f,titikt),coinObj.rotation);
                    
                        if(rand%3==1){
                            Instantiate(balokteghObj, new Vector3(0,2.88f,titikt),balokteghObj.rotation);
                            titiktm1="tengah";
                        }
                        else if(rand%3==2){
                            Instantiate(balokteghObj, new Vector3(1,2.88f,titikt),balokteghObj.rotation);
                            titiktm1="kanan";
                        }
                        else{
                            titiktm1="";
                        }
                      
                        if(rand%3==0){
                            Instantiate(coinObj, new Vector3(randt-1,2.88f,titikt+2),coinObj.rotation);
                            titiktm2="";
                            }
                        else if(rand%3==1){
                            Instantiate(balokteghObj, new Vector3(randt-1,2.88f,titikt+2),balokteghObj.rotation);
                            if(randt-1==-1)titiktm2="kiri";
                            else if(randt-1==0)titiktm2="tengah";
                            else if(randt-1==1)titiktm2="kanan";
                        }
                        else if(rand%3==2){
                            Instantiate(balokgd, new Vector3(randt-1,2.88f,titikt+2),balokgd.rotation);
                            if(randt-1==-1)titiktm2="kiri";
                            else if(randt-1==0)titiktm2="tengah";
                            else if(randt-1==1)titiktm2="kanan";
                        }
                    }   
            
                    else if(randN%3==1){
                        Instantiate(coinObj, new Vector3(0,3.08f,titikt),coinObj.rotation);
                        if(rand%3==0){
                            Instantiate(balokteghObj, new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
                            titiktm1="kiri";
                        }
                        else if(rand%3==2){
                            Instantiate(balokteghObj, new Vector3(1,2.88f,titikt),balokteghObj.rotation);
                            titiktm1="kanan";
                        }
                        else{
                            titiktm1="";
                        }
                        
                        if(rand%3==0){
                            Instantiate(coinObj, new Vector3(randt-1,2.88f,titikt+2),coinObj.rotation);
                            titiktm2="";
                            }
                        else if(rand%3==1){
                            Instantiate(balokteghObj, new Vector3(randt-1,2.88f,titikt+2),balokteghObj.rotation);
                            if(randt-1==-1)titiktm2="kiri";
                            else if(randt-1==0)titiktm2="tengah";
                            else if(randt-1==1)titiktm2="kanan";
                        }
                        else if(rand%3==2){
                            Instantiate(balokgd, new Vector3(randt-1,2.88f,titikt+2),balokgd.rotation);
                            if(randt-1==-1)titiktm2="kiri";
                            else if(randt-1==0)titiktm2="tengah";
                            else if(randt-1==1)titiktm2="kanan";
                        }
                    
                    }
                
                else if(randN%3==2){
                    Instantiate(coinObj, new Vector3(1,3.08f,titikt),coinObj.rotation);
                    if(rand%3==0){
                        Instantiate(balokteghObj, new Vector3(-1,2.88f,titikt),balokteghObj.rotation);
                        titiktm1="kiri";
                    }
                    else if(rand%3==1){
                        Instantiate(balokteghObj, new Vector3(0,2.88f,titikt),balokteghObj.rotation);
                        titiktm1="tengah";
                    }
                    else{
                        titiktm1="";
                    }
                    if(rand%3==0){
                        Instantiate(coinObj, new Vector3(randt-1,2.88f,titikt+2),coinObj.rotation);
                        titiktm2="";
                    }
                    else if(rand%3==1){
                        Instantiate(balokteghObj, new Vector3(randt-1,2.88f,titikt+2),balokteghObj.rotation);
                        if(randt-1==-1)titiktm2="kiri";
                        else if(randt-1==0)titiktm2="tengah";
                        else if(randt-1==1)titiktm2="kanan";
                    }
                    else if(rand%3==2){
                        Instantiate(balokgd, new Vector3(randt-1,2.88f,titikt+2),balokgd.rotation);
                        if(randt-1==-1)titiktm2="kiri";
                        else if(randt-1==0)titiktm2="tengah";
                        else if(randt-1==1)titiktm2="kanan";
                    }
                }
                titiktd=titikt;        
                titikt=titikt+4;
                }
            }}
            if(zScenePos<344){
                Instantiate(bbNoPit, new Vector3(0,1.9f,zScenePos),bbNoPit.rotation);
                zScenePos+=4;
            }

            timeTotal += Time.deltaTime;
            if(moveball.powerups=="strong"&&moveball.statuspowerup=="on"){
                wktpwrp=wktpwrp+Time.deltaTime;
            }
            else if(moveball.statuspowerup=="off"){
                wktpwrp=0;
            }
            if(GameProses2== "Fail"){
                waittoload+=Time.deltaTime;
            }
            
            
            if(waittoload>2){
                SceneManager.LoadScene("Game Proses 2");
                GameProses2="";
                zVelAdj=1;
                waittoload=0.0f;
            }
            }
        }
    

