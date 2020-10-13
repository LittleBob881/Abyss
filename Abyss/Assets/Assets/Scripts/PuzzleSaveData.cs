
using System;
using UnityEngine;

[System.Serializable]
public class PuzzleSaveData
{
    public int puzzleItemProgress;
    public int puzzleProgress;
    public Boolean[] unlocks;

    public PuzzleSaveData(PuzzleScript puzzle)
    {
        this.puzzleItemProgress = puzzle.GetPuzzleItemValue();
        this.puzzleProgress = puzzle.GetPuzzleValue();
        this.unlocks = puzzle.GetUnlock();
    }
}
