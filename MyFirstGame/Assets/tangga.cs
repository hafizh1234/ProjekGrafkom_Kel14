using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class tangga : MonoBehaviour {
    public static float vertVel=0;
    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public static float waittoload = 0;
    public static float zVelAdj = 1;
    public static string GameProses2= "";
    public Transform bbNoPit;
    public Transform bbPitMid;
    public float titikt=344;
    public string titiktm3="";
    public string titiktm2="";
    public string titiktm1="";
    public float titiktd=344;
    
    public Transform coinObj;
    public Transform balokteghObj;
    public Transform capsuleObj;
    public Transform balokgd;

    public int randN;
    public int randt;
    public int rand;
    public float zScenePos= 44;

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
                Instantiate(bbNoPit, new Vector3(0,1.9f,titikt),bbNoPit.rotation);
                
                randt=Random.Range(0,2);
                rand=Random.Range(0,10);
                randN=Random.Range(0,10);

                if(titikt>titiktd){
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
                            }
                        else if(rand%3==1){
                            Instantiate(coinObj, new Vector3(0,3.08f,titikt+2),coinObj.rotation);
                            }
                        Instantiate(balokteghObj,new Vector3(-1,2.88f,titikt+2),balokteghObj.rotation);
                        titiktm1=titiktm2;
                        titiktm2=titiktm3;
                        titiktm3="kiri";
                    }

                    else if(titiktm1=="kanan"&&titiktm2=="tengah"&&titiktm3=="tengah"){
                        if(rand%3==0){
                            Instantiate(coinObj, new Vector3(-1,3.08f,titikt+2),coinObj.rotation);
                            }
                        else if(rand%3==1){
                            Instantiate(coinObj, new Vector3(0,3.08f,titikt+2),coinObj.rotation);
                            }
                        Instantiate(balokteghObj,new Vector3(1,2.88f,titikt+2),balokteghObj.rotation);
                        titiktm1=titiktm2;
                        titiktm2=titiktm3;
                        titiktm3="kanan";
                    }


                    else{    
                        if(rand%3==0){
                            Instantiate(coinObj, new Vector3(randt-1,3.08f,titikt+2),coinObj.rotation);
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
                    titiktm1=titiktm2;
                    titiktm2=titiktm3;
                    
                    titiktd=titikt;
                    titikt+=4;
                }
             
            
                
                else if(titiktd==titikt){
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
                titikt+=4;
                }
             }
            }   
            if(zScenePos<344){
                Instantiate(bbNoPit, new Vector3(0,1.9f,zScenePos),bbNoPit.rotation);
                zScenePos+=4;
            }

            timeTotal += Time.deltaTime;
            if(GameProses2== "Fail"){
                waittoload+=Time.deltaTime;
            }
            
            
            if(waittoload>2){
                SceneManager.LoadScene("Game Proses 2");
            }

        }
    }

