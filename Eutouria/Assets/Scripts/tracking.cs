using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracking : MonoBehaviour
{
    public GameObject surfaceTracker, imageTracker;
    private void reset()
    {
        surfaceTracker.SetActive(false);
        imageTracker.SetActive(false);
    }
    public void ToggleImageTracking()
    {
        reset();
        imageTracker.SetActive(true);
    }
    public void ToggleSurfaceTracking()
    {
        reset();
        surfaceTracker.SetActive(true);
    }
}
