using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
    public static int PlayerScore3 = 0;
    public static int PlayerScore4 = 0;
    public int[] scores;
    bool winBool = false;

    public GUISkin layout;

    GameObject theBall;
    // Use this for initialization
    void Start()
    {
        theBall = GameObject.Find("Ball");
        scores = new int[4];
        scores[0] = PlayerScore1;
        scores[1] = PlayerScore2;
        scores[2] = PlayerScore3;
        scores[3] = PlayerScore4;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void Score(string wallID)
    {
        if (wallID == "RightBoundary")
        {
            PlayerScore1++;
            PlayerScore2++;
            PlayerScore4++;
        }
        else if (wallID == "LeftBoundary")
        {
            PlayerScore3++;
            PlayerScore2++;
            PlayerScore4++;
        }
        else if (wallID == "TopBoundary")
        {
            PlayerScore1++;
            PlayerScore2++;
            PlayerScore3++;
        }
        else if (wallID == "BottomBoundary")
        {
            PlayerScore1++;
            PlayerScore3++;
            PlayerScore4++;
        }
    }
    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 200 - 12, 20, 100, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 - 100 + 12, 20, 100, 100), "" + PlayerScore2);
        GUI.Label(new Rect(Screen.width / 2 + 40 + 12, 20, 100, 100), "" + PlayerScore3);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore4);
        string win = "";
        string end = "";
        if (PlayerScore1 == 15)
        {
            win += " Player 1";
            winBool = true;
        }
        if (PlayerScore2 == 15)
        {
            win += " Player 2";
            winBool = true;
        }
        if (PlayerScore3 == 15)
        {
            win += " Player 3";
            winBool = true;
        }
        if (PlayerScore4 == 15)
        {
            win += " Player 4";
            winBool = true;
        }
        if (winBool)
        {
            end += "wins";
            GUI.Label(new Rect(Screen.width / 2 - 300, 100, 2000, 1000), win);
            GUI.Label(new Rect(Screen.width / 2 - 300, 150, 2000, 1000), end);
            Application.Quit();
        }
        winBool = false;

    }
    void restart()
    {
        FindObjectOfType<BallScript>().ResetPos();
        PlayerScore1 = 0;
        PlayerScore2 = 0;
        PlayerScore3 = 0;
        PlayerScore4 = 0;
    }
}
