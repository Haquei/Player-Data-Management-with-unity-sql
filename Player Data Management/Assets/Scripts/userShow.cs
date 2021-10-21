using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userShow : MonoBehaviour
{
    string URL = "http://localhost/player_Data/showUser.php";


    public string[] userdata;

    public Text[] allData;
    
    IEnumerator Start()
    {
        WWW users = new WWW(URL);
        yield return users;

        string userinfo = users.text;
        userdata = userinfo.Split(';');
    
        for(int i=0; i<2; i++)//userdata.Length-1
        {
            allData[i].text = userdata[i];
        }
    }

    
    void Update()
    {
        
    }
   
}
