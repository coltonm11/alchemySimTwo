using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{
    MoleculeTable moleculicon;
    public bool reacting;
    public Dictionary<string, int> solutionMolecules = new Dictionary<string, int>();


    private void Start()
    {
        reacting = true;
        moleculicon = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<MoleculeTable>();
    }

    public void AddMolecule(Molecule molecule)
    {
        if (solutionMolecules.ContainsKey(molecule.name))
        {
            solutionMolecules[molecule.name] += 1;
        }
        if (!solutionMolecules.ContainsKey(molecule.name))
        {
            solutionMolecules.Add(molecule.GetName(), 1);
            moleculicon.SetMol(molecule.GetName(), molecule);
        }
    }

    public void RemoveMolecule(string mol)
    {
        solutionMolecules[mol] -= 1;
        if (solutionMolecules[mol] < 1)
            solutionMolecules.Remove(mol);
    }
}
