using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeTable : MonoBehaviour
{
    Dictionary<string, Molecule> moleculicon = new Dictionary<string, Molecule>();

    public void SetMol(string name, Molecule mol)
    {
        if (!moleculicon.ContainsKey(name))
        {
            moleculicon.Add(name, mol);
            print("MOLECULICON: " + moleculicon);
        }

    }

    public Molecule GetMol (string name)
    {
        return moleculicon[name];
    }
}
