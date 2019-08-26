using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecule : ScriptableObject
{
    public Dictionary<Atom, int> moleculeAtoms = new Dictionary<Atom, int>();
    public int electrons;
    public AtomDictionary atomDictionary;
    public int quantity;
    string name;

    public void AddAtom(Atom atom)
    {
        if (moleculeAtoms.ContainsKey(atom))
        {
            moleculeAtoms[atom] += 1;
        }
        else
        {
            moleculeAtoms.Add(atom, 1);
        }

        electrons += moleculeAtoms[atom] * atom.GetElectrons();
        Debug.Log(moleculeAtoms);
        Debug.Log(electrons);
    }

    public void SetName()
    {
        foreach(KeyValuePair<Atom, int> atom in moleculeAtoms)
        {
            name = name + atomDictionary.ClassToString(atom.Key);
        }
    }

    public string GetName()
    {
        return name;
    }

}