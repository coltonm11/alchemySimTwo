using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecule : ScriptableObject
{
    public Dictionary<Atom, int> moleculeAtoms = new Dictionary<Atom, int>();
    public int electrons;
    public AtomDictionary atomDictionary;
    public int quantity;
    public double bondStrength;
    string chemicalNotation;

    private void Awake()
    {
        atomDictionary = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<AtomDictionary>();
        moleculeAtoms.Add(atomDictionary.TypeToClass(AtomType.A), 0);
        moleculeAtoms.Add(atomDictionary.TypeToClass(AtomType.B), 0);
        moleculeAtoms.Add(atomDictionary.TypeToClass(AtomType.C), 0);
        moleculeAtoms.Add(atomDictionary.TypeToClass(AtomType.D), 0);
        moleculeAtoms.Add(atomDictionary.TypeToClass(AtomType.E), 0);
        moleculeAtoms.Add(atomDictionary.TypeToClass(AtomType.F), 0);
        moleculeAtoms.Add(atomDictionary.TypeToClass(AtomType.G), 0);
        moleculeAtoms.Add(atomDictionary.TypeToClass(AtomType.H), 0);
    }

    public void AddAtom(Atom atom)
    {
        moleculeAtoms[atom] += 1;
        electrons += moleculeAtoms[atom] * atom.GetElectrons();
    }

    public void SetName()
    {
        foreach (KeyValuePair<Atom, int> entry in moleculeAtoms)
        {
            if (entry.Value > 0)
                chemicalNotation += entry.Value + atomDictionary.TypeToString(entry.Key.getType());
        }
    }
    public string GetName()
    {
        return chemicalNotation;
    }

    public void SetBondStrength()
    {
        float sums = 0;
        int numberOfAtoms = 0;
        float differenceSums = 0;

        foreach (KeyValuePair<Atom, int> entry in moleculeAtoms)
        {
            if (entry.Value > 0)
            {
                sums += entry.Key.GetElectronegativity() * entry.Value;
                numberOfAtoms += entry.Value;
                Debug.Log("||||||| sums is: " + sums);
                Debug.Log("||||||| noAtoms is: " + numberOfAtoms);
            }
        }

        float average = sums / numberOfAtoms;

        Debug.Log("||||||| average is: " + average);

        foreach (KeyValuePair<Atom, int> entry in moleculeAtoms)
        {
            if (entry.Value > 0)
            {
                for(int i = 0; i < entry.Value; i++)
                {
                    differenceSums += Mathf.Abs(entry.Key.GetElectronegativity() - average);
                    Debug.Log("||||||| diff sums is: " + differenceSums);
                }
            }
                

        }

        float differenceAverage = differenceSums / numberOfAtoms;

        Debug.Log("||||||| diff average is: " + differenceAverage);

        bondStrength = differenceAverage;

        Debug.Log("Bond strenght of " + chemicalNotation + "is: " + bondStrength);

    }

}