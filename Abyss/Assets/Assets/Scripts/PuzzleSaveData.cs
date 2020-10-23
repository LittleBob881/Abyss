
using System;
using UnityEngine;

[System.Serializable]
public class PuzzleSaveData
{
    public int puzzleItemProgress;
    public Boolean[] unlocks;

    public PuzzleSaveData(PuzzleScript puzzle)
    {
        this.puzzleItemProgress = puzzle.GetPuzzleItemValue();
        this.unlocks = puzzle.GetUnlock();
    }
}
