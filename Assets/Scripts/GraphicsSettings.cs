using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Access to generic UI elements
using TMPro;//Access to text properties

public class GraphicsSettings : MonoBehaviour
{
    //Toggle switches for Fullscreen and Vsync
    [SerializeField] Toggle fullScreenTog, vSyncTog;
    [SerializeField] List<ResItem> resolutions = new List<ResItem>();
    private int selectedResolution;
    [SerializeField] TMP_Text resolutionText;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyGraphics()
    {
        //Resolutions settings
        Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, fullScreenTog.isOn);
    }


    public void ResLeft()
    {
        selectedResolution--;
        if (selectedResolution < 0) selectedResolution = resolutions.Count - 1;
        resolutionText.text = resolutions[selectedResolution].horizontal + "X" + resolutions[selectedResolution].vertical;
    }

    public void ResRight()
    {
        selectedResolution++;
        if (selectedResolution > resolutions.Count - 1) selectedResolution = 0;
        resolutionText.text = resolutions[selectedResolution].horizontal + "X" + resolutions[selectedResolution].vertical;

    }
}

[System.Serializable]
public class ResItem
{
    public int horizontal;//Screen width
    public int vertical;//Screen height
}