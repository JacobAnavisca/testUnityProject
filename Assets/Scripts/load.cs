using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class load : MonoBehaviour
{
    // public GameObject loadbutton;
    public Button loadButton;
    public Button startButton;
    public Sprite startSprite;
    public Sprite startPressedSprite;
    public bool defaultState;
    // Start is called before the first frame update
    void Start()
    {
        startSprite = Resources.Load<Sprite>("UI/Start_Default");
        startPressedSprite = Resources.Load<Sprite>("UI/Start_Pressed");
        defaultState = true;
      // loadbutton = GameObject.Find("Load Button");
      loadButton = GetComponent<Button>();
      Debug.Log("Started!");
      loadButton.onClick.AddListener(this.switchImage);
    }

    // Update is called once per frame
    void Update()
    {
        // button = loadbutton.GetComponent<Button>();
        // button = GetComponent<Button>();
        // button.clicked += () => Debug.Log("Clicked!");
        // loadbutton.clickable.clicked += () => Debug.Log("Clicked!");
    }

    public void switchImage() {
        Debug.Log("Clicked!");
        defaultState = !defaultState;
        startButton = GameObject.Find("Start Button").gameObject.GetComponent<Button>();
        if (defaultState) {
            startButton.image.sprite = startSprite;
        } else {
            startButton.image.sprite = startPressedSprite;
        }
    }
}
