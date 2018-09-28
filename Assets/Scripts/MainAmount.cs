using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainAmount : MonoBehaviour
{
    [Header("Financiën")]
    public Dropdown Financien;
    public int TitansInt;
    public int CoinsInt;

    [Header("Industrie")]
    public Dropdown Industrie;
    public int GrondstoffenInt;
    public int GoudInt;
    public int EnergieInt;
    public int HoutInt;
    public int PapierInt;
    public int GasInt;

    [Header("Voeding")]
    public Dropdown Voeding;
    public int VoedselInt;
    public int KoffieInt;
    public int TheeInt;
    public int WijnInt;
    public int ZuivelInt;

    [Header("Vervoer")]
    public Dropdown Vervoer;
    public int VervoerInt;
    public int ScheepsbouwInt;
    public int AutosInt;
    public int VliegtuigenInt;

    [Header("Productie")]
    public Dropdown Productie;
    public int HoogovensInt;
    public int InstrumentenInt;
    public int WapensFabriekInt;

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /*public bool Financien;
    public bool Industrie;*/

    void Start()
    {
        //Financiën
        Financien.options.Clear();
        Financien.options.Add(new Dropdown.OptionData() {text = "Titans:\n12"});
        Financien.options.Add(new Dropdown.OptionData() {text = "Coins:\n12" });
        //Industrie

    }

    private void Update()
    {
        /*//Financiën
        if (Financien == true)
        {
            Titan.text = "Titan = " + TitanInt;
            Coins.text = "Coins = " + CoinsInt; 
        }
        else
        {
            Titan.text = "";
            Coins.text = "";
        }
        //Industrie
        if (Industrie == true)
        {

        }
        else
        {
            Grondstoffen.text = "";
            Goud.text = "";
            Hoogovens.text = "";
            Instrumenten.text = "";

        }*/
    }
}