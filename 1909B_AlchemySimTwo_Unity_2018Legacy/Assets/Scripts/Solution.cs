using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{
    MoleculeTable molTable;
    public Dictionary<string, int> solutionMolecules = new Dictionary<string, int>();

    private void Start()
    {
        molTable = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<MoleculeTable>();
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
            molTable.SetMol(molecule.name, molecule);
        }
        //print(solutionMolecules);
    }

    
}
