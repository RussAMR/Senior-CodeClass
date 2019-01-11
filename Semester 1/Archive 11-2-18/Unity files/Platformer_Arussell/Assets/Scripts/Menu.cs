using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private bool ispaused = false;


    public GUISkin guiSkin;
    public Texture2D background, LOGO;
    public bool DragWindow = false;
    public string leveltoLoadWhenClickedplay = "SampleScene";
    public string[] AboutTextLines = new string[0];

    public string clicked = "", MessageDisplayOnAbout = "About \n";
    private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2, 200, 200);
    private float volume = 1.0f;
    private float SFXvolume = 1f;
    private float BGMvolume = 1f;
    public static bool pause;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ispaused = !ispaused;
            clicked = "";
        }
        if (ispaused)
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
        }
        else
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
        }
    }
    private void OnGUI()
    {
        GUI.skin = guiSkin;

        if (clicked == "" && ispaused)
        {
            WindowRect = GUI.Window(0, WindowRect, menuFunc, "Main Menu");
        }

        if (clicked == "options")
        {
            WindowRect = GUI.Window(1, WindowRect, optionsFunc, "Options");
        }
        else if (clicked == "resolution")
        {
            GUILayout.BeginVertical();

            for (int x = 0; x < Screen.resolutions.Length; x++)
            {
                if (GUILayout.Button(Screen.resolutions[x].width + "X" + Screen.resolutions[x].height))
                {
                    Screen.SetResolution(Screen.resolutions[x].width, Screen.resolutions[x].height, true);
                }
            }

            GUILayout.EndVertical();
            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Back"))
            {
                clicked = "options";
            }

            GUILayout.EndHorizontal();
        }
    }
    private void optionsFunc(int id)
    {
        if (GUILayout.Button("Resolution"))
        {
            clicked = "resolution";
        }

        GUILayout.Box("Master Volume");
        volume = GUILayout.HorizontalSlider(volume, 0.0f, 2.0f);
        AudioListener.volume = volume;

        GUILayout.Box("SFX Volume");
        SFXvolume = GUILayout.HorizontalSlider(SFXvolume, 0.0f, 2.0f);
        AudioManager.Instance.soundEffectSource.volume = SFXvolume;

        GUILayout.Box("BGM Volume");
        BGMvolume = GUILayout.HorizontalSlider(BGMvolume, 0.0f, 2.0f);
        AudioManager.Instance.BGMSource.volume = BGMvolume;

        if (GUILayout.Button("Back"))
        {
            clicked = "";
        }

        if (DragWindow)
            GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
    }
    private void menuFunc(int id)
    {
        if (ispaused == true)
        {
            //buttons 
            if (GUILayout.Button("Play Game"))
            {
                //play game is clicked
                //SceneManager.LoadScene(levelToLoadWhenClickedPlay);
                ispaused = false;
            }

            if (GUILayout.Button("Options"))
            {
                clicked = "options";
            }

            if (GUILayout.Button("Restart Level"))
            {
                SceneManager.LoadScene("SampleScene");
            }

            //if (GUILayout.Button("About"))
            //{
            //    clicked = "about";
            //}

            if (GUILayout.Button("Quit Game"))
            {
                Application.Quit();
            }

            if (DragWindow)
                GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
        }
    }
}
