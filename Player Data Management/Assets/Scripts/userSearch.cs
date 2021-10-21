using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userSearch : MonoBehaviour
{
    string URL = "http://localhost/player_Data/showUser.php";
    private string[] userdata;
    public Text[] allData;

    public string p_name;

    public InputField player_name;

    IEnumerator Start()
    {
        WWW users = new WWW(URL);
        yield return users;

        string userinfo = users.text;
        userdata = userinfo.Split(';');

       
    }

    public void Search(string name)
    {
        WWWForm form = new WWWForm();
        form.AddField("addUsername", name);
    
        WWW www = new WWW(URL, form);
    }

    public void SearchButton()
    {
        p_name = player_name.GetComponent<InputField>().text;

        Search(p_name);
       
    }
}
