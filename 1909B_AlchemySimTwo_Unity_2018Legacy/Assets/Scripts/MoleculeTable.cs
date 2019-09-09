using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeTable : MonoBehaviour
{
    Dictionary<string, Molecule> moleculicon = new Dictionary<string, Molecule>();

    public void SetMol(string name, Molecule mol)
    {
        moleculicon.Add(name, mol);
    }

    public Molecule GetMol (string name)
    {
        return moleculicon[name];
    }
}
