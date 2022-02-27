using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeOpacity : MonoBehaviour
{
    public Button changeButton;
    bool clicked;

    private void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!clicked)
        {
            changeButton.onClick.AddListener(disablebutton);
        }
        else if (clicked)
        {
            changeButton.onClick.AddListener(enablebutton);
        }
        
    }

    void disablebutton()
    {
        ColorBlock colors = changeButton.colors;
        colors.normalColor = new Color32(255, 255, 255, 127);
        colors.highlightedColor = new Color32(255, 255, 255, 127);
        changeButton.colors = colors;
        clicked = true;
        switch (changeButton.name.ToString())
        {
            case "PokeBall":
                NewObjectPooler.objectball = changeButton.name.ToString() + "(Clone)";
                break;

            case "Dice":
                NewObjectPooler.objectdice = changeButton.name.ToString() + "(Clone)";
                break;

            case "Milk":
                NewObjectPooler.objectmilk = changeButton.name.ToString() + "(Clone)";
                break;
        }
    }

    void enablebutton()
    {
        ColorBlock colors = changeButton.colors;
        colors.normalColor = Color.white;
        colors.highlightedColor = Color.white; ;
        changeButton.colors = colors;
        clicked = false;
        switch (changeButton.name.ToString())
        {
            case "PokeBall":
                NewObjectPooler.objectball = null;
                break;

            case "Dice":
                NewObjectPooler.objectdice = null;
                break;

            case "Milk":
                NewObjectPooler.objectmilk = null;
                break;
        }
    }

}
