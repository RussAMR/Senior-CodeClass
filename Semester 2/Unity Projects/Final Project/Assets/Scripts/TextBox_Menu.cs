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
    string starter = "Hello, The start button can be found in the bottom left.";
    string special = "The Pellet is hidden around here somewhere see if you can find it.";
    List<string> text = new List<string>() { "Welcome to RollerCity", "This is the tutorial","Use W to move forward and S to move backward","Use the A and D keys to move left and right","Collect the green pellets to progress","The true exit is a green pipe you must land in." };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        timer += time * Time.deltaTime;
        if (timer >= 4)
        {


            if (collision.collider.tag == "Special")
            {
                textbox.text = special;
                if (timer >= 4)
                {
                    Destroy(gameObject);
                }
            }
            else if (collision.collider.tag == "Starter")
            {
                textbox.text = starter;
                if(timer >= 4)
                {
                    Destroy(gameObject);
                }
            }
            else if (collision.collider.tag == "Tutorial")
            {
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
            else
            {

            }
        }
    }
}
