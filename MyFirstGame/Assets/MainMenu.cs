﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

   }
   public void  QuitGame()
   {
       Debug.Log("Kamu Telah Keluar Dari Game Flash Ball 0.7");
       Application.Quit();
   }
   public void resetCointoZero(){
       tangga.coinTotal=0;
       tangga.timeTotal=0;
   }
}
