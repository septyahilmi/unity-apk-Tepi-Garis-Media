using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Master : MonoBehaviour
{
    public GameObject panelAwal, panelBawah, btnSwipeUP, btnMute, btnClose, textJudul,
                        btnPlay, btnPause, btnNext, btnPrev, slider, waktu;
    public Animator animPanelBawah, animPanelAwal;

    
    // Update is called once per frame
    void Update()
    {
      
    }
    
    public void panelAwalTouch()
    {
        panelAwal.SetActive(true);
    }

    void animationSwipeUp()
    {
        panelBawah.SetActive(true);
        //btnPlay.SetActive(false);
        //btnPause.SetActive(false);
        btnNext.SetActive(false);
        btnPrev.SetActive(false);
        slider.SetActive(false);
        waktu.SetActive(false);
        btnSwipeUP.SetActive(false); 
     
        
    }

    void animationSwipeDown()
    {
        //btnPlay.SetActive(true);
        //btnPause.SetActive(true);
        btnNext.SetActive(true);
        btnPrev.SetActive(true);
        slider.SetActive(true);
        waktu.SetActive(true);
        btnSwipeUP.SetActive(true);
        
        
    }
    public void panelSwipeUp()
    {
        animPanelBawah.SetInteger("isBawahUp", 2);
        Invoke("animationSwipeUp", 1f);
        animPanelAwal.SetInteger("isMuncul", 1);

        /*   panelBawah.SetActive(true);
             btnPlay.SetActive(false);
             btnPause.SetActive(false);
             btnNext.SetActive(false);
             btnPrev.SetActive(false);
             slider.SetActive(false);
             btnSwipeUP.SetActive(false);
          */
    }

    public void panelSwipeDown()
    {
        animPanelBawah.SetInteger("isBawahUp", 1);
        Invoke("animationSwipeDown", 1f);
        animPanelAwal.SetInteger("isMuncul", 0);


        /*btnPlay.SetActive(true);
          btnPause.SetActive(true);
          btnNext.SetActive(true);
          btnPrev.SetActive(true);
          slider.SetActive(true);
          btnSwipeUP.SetActive(true);
       */
    }

    public void panelClose()
    {
        
        panelAwal.SetActive(false);
        panelBawah.SetActive(false);
        //btnPlay.SetActive(true);
        //btnPause.SetActive(true);
        btnNext.SetActive(true);
        btnPrev.SetActive(true);
        slider.SetActive(true);
        waktu.SetActive(true);
        btnSwipeUP.SetActive(true);
    }

}
