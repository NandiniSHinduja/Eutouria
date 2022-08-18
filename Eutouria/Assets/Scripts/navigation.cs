using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigation : MonoBehaviour
{
    public GameObject MainPanel, TourGuide, TouristSpot, TouristInfo, About, Fictional, Fictional2, Famous, Famous2, Damaged, Damaged2, ARView;

    public void reset()
    {
        MainPanel.SetActive(false);
        TourGuide.SetActive(false);
        TouristSpot.SetActive(false);
        TouristInfo.SetActive(false);
        About.SetActive(false);
        Fictional.SetActive(false);
        Fictional2.SetActive(false);
        Famous.SetActive(false);
        Famous2.SetActive(false);
        Damaged.SetActive(false);
        Damaged2.SetActive(false);
        ARView.SetActive(false);
       
    }

    public void toTourGuide()
    {
        reset();
        TourGuide.SetActive(true);
    }

    public void toTouristSpot()
    {
        reset();
        TouristSpot.SetActive(true);
    }

    public void toTouristInfo()
    {
        reset();
        TouristInfo.SetActive(true);
    }

    public void Home()
    {
        reset();
        MainPanel.SetActive(true);
    }

    public void toAbout()
    {
        reset();
        About.SetActive(true);
    }

    public void guideToFiction()
    {
        reset();
        Fictional.SetActive(true);
    }

    public void spotToFiction()
    {
        reset();
        Fictional2.SetActive(true);
    }

    public void guideToFamous()
    {
        reset();
        Famous.SetActive(true);
    }
    public void guideToDamaged()
    {
        reset();
        Damaged.SetActive(true);
    }
    public void spotToFamous()
    {
        reset();
        Famous2.SetActive(true);
    }
    public void spotToDamaged()
    {
        reset();
        Damaged2.SetActive(true);
    }
    public void aboutBackToMain()
    {
        reset();
        MainPanel.SetActive(true);
    }
    public void guideBackToMain()
    {
        reset();
        MainPanel.SetActive(true);
    }
    public void spotsBackToMain()
    {
        reset();
        MainPanel.SetActive(true);
    }
    public void infoBackToMain()
    {
        reset();
        MainPanel.SetActive(true);
    }
    public void fictionalToGuide()
    {
        reset();
        TourGuide.SetActive(true);
    }
    public void famousToGuide()
    {
        reset();
        TourGuide.SetActive(true);
    }
    public void damagedToGuide()
    {
        reset();
        TourGuide.SetActive(true);
    }
    public void fictionalToSpot()
    {
        reset();
        TouristSpot.SetActive(true);
    }
    public void famousToSpot()
    {
        reset();
        TouristSpot.SetActive(true);
    }
    public void damagedToSpot()
    {
        reset();
        TouristSpot.SetActive(true);
    }
    public void SpotInfoToArView()
    {
        reset();
        ARView.SetActive(true);
    }
    public void ARToSpotsInfo()
    {
        reset();
        TouristInfo.SetActive(true);
    }
   



}
