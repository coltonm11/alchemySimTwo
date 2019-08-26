using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{
    public Dictionary<string, Molecule> solutionMolecules = new Dictionary<string, Molecule>();

    public void AddMolecule(Molecule molecule)
    {
        if (solutionMolecules.ContainsKey(molecule.name))
        {
            solutionMolecules[molecule.name].quantity += 1;
        }
        else
        {
            solutionMolecules.Add(molecule.GetName(), molecule);
        }
        print(solutionMolecules.);
    }

    
}
