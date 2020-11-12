using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System;

public class WordGetter : MonoBehaviour
{

    public InputField inputField;
    public char letter;
    static public string word;
    static private string trimmed_word;
    static private int bodyState = 0;
    static private int correct = 0;
    private int guessed = 0;
    public GameObject space1;
    public GameObject space2;
    public GameObject space3;
    public GameObject space4;
    public GameObject space5;
    public GameObject space6;
    public GameObject space7;
    public GameObject space8;
    public GameObject space9;
    public GameObject space10;
    public GameObject space11;
    public GameObject space12;
    public GameObject space13;
    public GameObject space14;
    public GameObject Head;
    public GameObject Body;
    public GameObject LeftLeg;
    public GameObject RightLeg;
    public GameObject RightArm;
    public GameObject LeftArm;
    public Text zero;
    public Text one;
    public Text two;
    public Text three;
    public Text four;
    public Text five;
    public Text six;
    public Text seven;
    public Text eight;
    public Text nine;
    public Text ten;
    public Text eleven;
    public Text twelve;
    public Text thirteen;


    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            trimmed_word = word.Replace(" ", "");
            if (word.Length >= 1)
            {
                if (word[0] != ' ')
                {
                    var cubeRenderer = space1.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 2)
            {
                if (word[1] != ' ')
                {
                    var cubeRenderer = space2.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 3)
            {
                if (word[2] != ' ')
                {
                    var cubeRenderer = space3.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 4)
            {
                if (word[3] != ' ')
                {
                    var cubeRenderer = space4.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 5)
            {
                if (word[4] != ' ')
                {
                    var cubeRenderer = space5.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 6)
            {
                if (word[5] != ' ')
                {
                    var cubeRenderer = space6.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 7)
            {
                if (word[6] != ' ')
                {
                    var cubeRenderer = space7.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 8)
            {
                if (word[7] != ' ')
                {
                    var cubeRenderer = space8.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 9)
            {
                if (word[8] != ' ')
                {
                    var cubeRenderer = space9.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 10)
            {
                if (word[9] != ' ')
                {
                    var cubeRenderer = space10.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 11)
            {
                if (word[10] != ' ')
                {
                    var cubeRenderer = space11.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 12)
            {
                if (word[11] != ' ')
                {
                    var cubeRenderer = space12.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 13)
            {
                if (word[12] != ' ')
                {
                    var cubeRenderer = space13.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }
            if (word.Length >= 14)
            {
                if (word[13] != ' ')
                {
                    var cubeRenderer = space14.GetComponent<Renderer>();
                    cubeRenderer.material.SetColor("_Color", Color.red);
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    private void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public void GetText()
    {
        //Change scene
        word = inputField.text;
        SceneManager.LoadScene("Main");
    }

    private void printBody(int guess)
    {
        if (guess == 1)
        {
            return;
        } else
        {
            if (bodyState == 0)
            {
                var cubeRenderer = Head.GetComponent<Renderer>();
                cubeRenderer.material.SetColor("_Color", Color.red);
                bodyState++;
            } else if (bodyState == 1)
            {
                var cubeRenderer = Body.GetComponent<Renderer>();
                cubeRenderer.material.SetColor("_Color", Color.red);
                bodyState++;
            } else if (bodyState == 2)
            {
                var cubeRenderer = RightArm.GetComponent<Renderer>();
                cubeRenderer.material.SetColor("_Color", Color.red);
                bodyState++;
            } else if (bodyState == 3)
            {
                var cubeRenderer = LeftArm.GetComponent<Renderer>();
                cubeRenderer.material.SetColor("_Color", Color.red);
                bodyState++;
            } else if (bodyState == 4)
            {
                var cubeRenderer = LeftLeg.GetComponent<Renderer>();
                cubeRenderer.material.SetColor("_Color", Color.red);
                bodyState++;
            } else if (bodyState == 5)
            {
                var cubeRenderer = RightLeg.GetComponent<Renderer>();
                cubeRenderer.material.SetColor("_Color", Color.red);
                bodyState++;
                Invoke("GameOver", 3);
            }
        }
    }
    public void shouldPrint()
    {
        if (word.Length >= 1)
        {
            if (char.ToLower(word[0]) == letter)
            {
                correct++;
                zero.color = Color.red;
                zero.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 2)
        {
            if (char.ToLower(word[1]) == letter)
            {
                correct++;
                one.color = Color.red;
                one.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 3)
        {
            if (char.ToLower(word[2]) == letter)
            {
                correct++;
                two.color = Color.red;
                two.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 4)
        {
            if (char.ToLower(word[3]) == letter)
            {
                correct++;
                three.color = Color.red;
                three.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 5)
        {
            if (char.ToLower(word[4]) == letter)
            {
                correct++;
                four.color = Color.red;
                four.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 6)
        {
            if (char.ToLower(word[5]) == letter)
            {
                correct++;
                five.color = Color.red;
                five.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 7)
        {
            if (char.ToLower(word[6]) == letter)
            {
                correct++;
                six.color = Color.red;
                six.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 8)
        {
            if (char.ToLower(word[7]) == letter)
            {
                correct++;
                seven.color = Color.red;
                seven.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 9)
        {
            if (char.ToLower(word[8]) == letter)
            {
                correct++;
                eight.color = Color.red;
                eight.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 10)
        {
            if (char.ToLower(word[9]) == letter)
            {
                correct++;
                nine.color = Color.red;
                nine.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 11)
        {
            if (char.ToLower(word[10]) == letter)
            {
                correct++;
                ten.color = Color.red;
                ten.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 12)
        {
            if (char.ToLower(word[11]) == letter)
            {
                correct++;
                eleven.color = Color.red;
                eleven.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 13)
        {
            if (char.ToLower(word[12]) == letter)
            {
                correct++;
                twelve.color = Color.red;
                twelve.text = letter.ToString();
                guessed = 1;
            }
        }
        if (word.Length >= 14)
        {
            if (char.ToLower(word[13]) == letter)
            {
                correct++;
                thirteen.color = Color.red;
                thirteen.text = letter.ToString();
                guessed = 1;
            }
        }
        if (correct >= trimmed_word.Length)
        {
            Invoke("Win", 1);
        } else
        {
            printBody(guessed);
        }
    }
}


