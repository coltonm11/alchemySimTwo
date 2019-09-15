using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoleculeTable : MonoBehaviour
{
    Dictionary<string, Molecule> moleculicon = new Dictionary<string, Molecule>();
    public GameObject debugWindowObject;
    TextMeshProUGUI windowText;

    private void Awake()
    {
        windowText = debugWindowObject.GetComponent<TextMeshProUGUI>();
    }

    public void SetMol(string name, Molecule mol)
    {
        if (!moleculicon.ContainsKey(name))
        {
            moleculicon.Add(name, mol);
        }
        UpdateDebugWindow();
    }

    public Molecule GetMol (string name)
    {
        return moleculicon[name];
    }

    void UpdateDebugWindow()
    {
        windowText.text = "";
        foreach (KeyValuePair<string, Molecule> entry in moleculicon)
        {
            windowText.text += entry.Value.GetName() + "\n";
        }
    }
}
