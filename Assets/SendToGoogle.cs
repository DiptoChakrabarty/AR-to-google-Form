using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendToGoogle : MonoBehaviour
{

    public GameObject username;
    public GameObject email;
    public GameObject phone;

    private string Name;
    private string Email;
    private string Phone;

   [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLScnexmVlEQjY5vSL7utDfwnCZvbPB4mj9uOW55pboB5L05cKw/formResponse";

    IEnumerator Post(string name, string email, string phone) {
        WWWForm form = new WWWForm();
        form.AddField("entry.757523004", name);
        form.AddField("entry.1800522340", email);
        form.AddField("entry.778873109", phone);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }
    public void Send() {
        Name = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Phone = phone.GetComponent<InputField>().text;
        StartCoroutine(Post(Name, Email, Phone));
   
}


}
