using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecule : ScriptableObject
{
    public Dictionary<Atom, int> moleculeAtoms = new Dictionary<Atom, int>();
    public int electrons;
    public AtomDictionary atomDictionary;
    public int quantity;
    public float electronegativity;
    public float bondStrength;
    public float density;
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
    }

    public void SetValues()
    {
        chemicalNotation = "";
        electrons = 0;

        foreach (KeyValuePair<Atom, int> entry in moleculeAtoms)
        {
            if (entry.Value > 0)
            {
                // SetName
                chemicalNotation += entry.Value + atomDictionary.TypeToString(entry.Key.getType());
                // SetElectrons
                electrons += entry.Key.GetElectrons() * entry.Value;
            }
        }
        SetBondStrength();
        SetDensity();
    }

    void SetBondStrength()
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
            }
        }

        float average = sums / numberOfAtoms;
        electronegativity = average;

        foreach (KeyValuePair<Atom, int> entry in moleculeAtoms)
        {
            if (entry.Value > 0)
            {
                for (int i = 0; i < entry.Value; i++)
                {
                    differenceSums += Mathf.Abs(entry.Key.GetElectronegativity() - average);
                }
            }
        }

        float differenceAverage = differenceSums / numberOfAtoms;

        bondStrength = differenceAverage;
    }

    void SetDensity()
    {
        float totalMass = 0;

        foreach (KeyValuePair<Atom, int> entry in moleculeAtoms)
        {
            if (entry.Value > 0)
            {
                for (int i = 0; i < entry.Value; i++)
                {
                    totalMass += entry.Key.GetMass();
                }
            }
        }

        density = totalMass / electrons;
    }

    // ----------------------------------
    // ------ GET VALUES ----------------
    // ----------------------------------

    public string GetName()
    {
        return chemicalNotation;
    }

    public int GetElectrons()
    {
        return electrons;
    }

    public float GetElectronegativity()
    {
        return electronegativity;
    }

    public float GetBondStrength()
    {
        return bondStrength;
    }

    public float GetDensity()
    {
        return density;
    }

}