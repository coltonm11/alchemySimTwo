using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecule : ScriptableObject
{
    public Dictionary<Atom, int> moleculeAtoms = new Dictionary<Atom, int>();
    public int electrons;
    public AtomDictionary atomDictionary;
    public int quantity;
    string chemicalNotation;

    private void Awake()
    {
        atomDictionary = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<AtomDictionary>();
        chemicalNotation = "ass";
    }

    public void AddAtom(Atom atom)
    {
        Debug.Log("MOLECULE: Started AddAtom();");
        if (moleculeAtoms.ContainsKey(atom))
        {
            moleculeAtoms[atom] += 1;
        }
        else
        {
            moleculeAtoms.Add(atom, 1);
        }
        Debug.Log("MOLECULE: just added " + atom);
        electrons += moleculeAtoms[atom] * atom.GetElectrons();
        //Debug.Log(moleculeAtoms);
        //Debug.Log(electrons);
        //SetName();
    }

    public void SetName()
    {
        Debug.Log("MOLECULE: SetName() is called");
        foreach(KeyValuePair<Atom, int> atom in moleculeAtoms)
        {
            Debug.Log("MOL: atom.Key is " + atom.Key);
            //AtomType type = atom.Key.getType();
            //chemicalNotation = chemicalNotation + atomDictionary.TypeToString(type);
        }
    }

    public string GetName()
    {
        return chemicalNotation;
    }

}