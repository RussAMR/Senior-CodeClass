using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBox_Menu : MonoBehaviour
{
    float timer = 0;
    float time = 1;
    int counter = 0;
    GameObject Textmeshpro;
    public TextMeshProUGUI textbox;
    List<string> text = new List<string>() { "The Start button can be found in the bottom right." };

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
            if (counter < text.Count)
            {
                textbox.text = text[counter];
                counter++;
            }
            else
            {
                Destroy(gameObject);
            }
            timer = 0;
        }
    }
}
