using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    public Text message;
    void Start()
    {
        message=this.GetComponent<Text>();
        message.enabled = false;
    }
    public void SetMessage(GameObject go)
    {
        message.text = "You Collected an Egg";
        message.enabled = true;
        Invoke("Turnoff", 5f);
    }
    void Turnoff()
    {
        message.enabled = false;
    }
}
