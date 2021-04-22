using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class togglePanel : MonoBehaviour
{
    // public GameObject loadbutton;
    public Button startButton;
    public dynamic panelMenu;
    // Start is called before the first frame update
    void Start()
    {
        panelMenu = GameObject.Find("Panel").gameObject;
        panelMenu.GetComponent<RectTransform>().localScale = new Vector3(0, 0);
		startButton = GetComponent<Button>();
		Debug.Log("Started Start!");
		startButton.onClick.AddListener(this.togglePanelState);
    }

    // Update is called once per frame
    void Update()
    {
        // button = loadbutton.GetComponent<Button>();
        // button = GetComponent<Button>();
        // button.clicked += () => Debug.Log("Clicked!");
        // loadbutton.clickable.clicked += () => Debug.Log("Clicked!");
    }

    public void togglePanelState() {
        Debug.Log("Clicked Start!");
    	panelMenu.GetComponent<RectTransform>().localScale = new Vector3(1, 1);
    }
}
