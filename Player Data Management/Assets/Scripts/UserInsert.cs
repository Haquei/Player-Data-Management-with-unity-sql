using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInsert : MonoBehaviour
{

    string URL = "http://localhost/player_Data/userInsert.php";

    public string p_name, age, type;

    public InputField player_name;
    public InputField player_age;
    public InputField player_type;

    public GameObject add_player_canvus;
    public GameObject add_player_button;
    public GameObject Slider;


    void Start()
    {
        add_player_canvus.SetActive(false);
        add_player_button.SetActive(true);
        Slider.SetActive(true);

}

    
    void Update()
    {
        
       
        
    }

    public void addUser(string name, string age, string type)
    {
        WWWForm form = new WWWForm();
        form.AddField("addUsername", name);
        form.AddField("addAge", age);
        form.AddField("addType", type);


        WWW www = new WWW(URL, form);
    }

    public void saveData()
    {
        p_name = player_name.GetComponent<InputField>().text;
        age = player_age.GetComponent<InputField>().text;
        type = player_type.GetComponent<InputField>().text;


        addUser(p_name, age, type);
        add_player_canvus.SetActive(false);
        player_name.text = "";
        player_age.text = "";
        player_type.text = "";
        add_player_button.SetActive(true);
        Slider.SetActive(true);


    }

    public void Show_ADD_player()
    {
        add_player_canvus.SetActive(true);
        add_player_button.SetActive(false);
        Slider.SetActive(false);
    }
}
