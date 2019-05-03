using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextShade : MonoBehaviour
{
    float timer = 0;
    float time = 1;
    int counter = 0;
    string hold = " ";
    GameObject Textmeshpro;
    public TextMeshProUGUI textbox;
    List<string> text = new List<string>() {"Use WASD to move" , "Hello welcome Rollercity,","Hunt for the green pellets to solve the puzzle","They'll open new paths for you to take.", "This will take you to the menu screen thank you for playing." };
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timer += time * Time.deltaTime;

        if (timer >= 4)
        {
            if(counter < text.Count)
            {
                textbox.text = text[counter];
                counter++;
            }
            else if(counter == text.Count + 1)
            {
                textbox.text = hold;
                counter++;
            }
            else
            {
                Destroy(gameObject);
            }
            timer = 0;
        }
        

    }
    private void LateUpdate()
    {

    }
}
