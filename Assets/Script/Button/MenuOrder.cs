using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOrder : MonoBehaviour
{
    PlayerData PlayerData;
    // Start is called before the first frame update
    void Start()
    {
        PlayerData = GameObject.Find("SystemManager").GetComponent<PlayerData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if(this.gameObject.name == "Menu1Add")
        {
            PlayerData.MenuList.Add("Coffee");
        }
        if(this.gameObject.name == "Menu2Add")
        {
            PlayerData.MenuList.Add("Omrice");
        }
        if(this.gameObject.name == "Menu3Add")
        {
<<<<<<< HEAD
            PlayerData.MenuList.Add("Cat");
        }
        if(this.gameObject.name == "Menu4Add")
        {
            PlayerData.MenuList.Add("Shark");
=======
            PlayerData.MenuList.Add("Toast");
        }
        if(this.gameObject.name == "Menu4Add")
        {
            PlayerData.MenuList.Add("Naporitan");
>>>>>>> weizu/main
        }
    }
}
