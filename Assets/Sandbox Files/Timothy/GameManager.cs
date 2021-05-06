using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{    
    public Text textbox;
    public static Text MainTextbox;
    public Image image;
    public static Image MainTextBoxImage;
    //public static int ScoreManager;
    //public Text cointextbox;

    // Start is called before the first frame update
    void Start()
    {
        MainTextbox = textbox;
        MainTextBoxImage = image;
        //ScoreManager = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //cointextbox.text = "Score: "+ScoreManager;
    }
}
