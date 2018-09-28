using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item
{
    public string Name = "";
    public int HP = 0;
    public int AP = 0;
    public int PA = 0;
}

public class Test : MonoBehaviour
{
    //You can polate the list from inspector
    public List<Item> Items = new List<Item>() {
        new Item() { Name = "First Item", AP = -50, PA = 25, HP = 10 },
        new Item() { Name = "Second Item", AP = 30, PA = 100, HP = -25 },
        new Item() { Name = "Sun Amulet", AP = 10, PA = 20, HP = 0 }
    };

    public Dropdown dropdown;
    public Text selectedName;
    public void Dropdown_IndexChanged(int index)
    {
        Item selected = Items[dropdown.value];
        selectedName.text = selected.Name
            + "\n HP = " + selected.HP.ToString()
            + "\n AP =" + selected.AP.ToString()
            + " \n PA =" + selected.PA.ToString();
    }

    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        dropdown.ClearOptions();
        List<string> newOptions = new List<string>();
        for (int i = 0; i < Items.Count; i++)
        {
            newOptions.Add(Items[i].Name);
        }
        dropdown.AddOptions(newOptions);
        Dropdown_IndexChanged(0); //select first
    }
}