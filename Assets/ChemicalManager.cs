using UnityEngine;
using System.Collections.Generic;

public class ChemicalManager : MonoBehaviour
{
    public static ChemicalManager instance;

    public List<string> pickedChemicals =
        new List<string>();

    void Awake()
    {
        instance = this;
    }

    public void AddChemical(string chemical)
    {
        pickedChemicals.Add(chemical);

        UIManager.instance.ShowMessage(chemical + " Added");
    }
}