using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class closeButton : MonoBehaviour
{
    // public GameObject loadbutton;
    public Button close;
    public dynamic panelMenu;
    // Start is called before the first frame update
    void Start()
    {
        panelMenu = GameObject.Find("Panel").gameObject;
		close = GetComponent<Button>();
		Debug.Log("Started Close!");
		close.onClick.AddListener(this.closePanel);
    }

    // Update is called once per frame
    void Update()
    {
        // button = loadbutton.GetComponent<Button>();
        // button = GetComponent<Button>();
        // button.clicked += () => Debug.Log("Clicked!");
        // loadbutton.clickable.clicked += () => Debug.Log("Clicked!");
    }

    public void closePanel() {
        Debug.Log("Clicked Close!");
        panelMenu.GetComponent<RectTransform>().localScale = new Vector3(0, 0);
    }
}
