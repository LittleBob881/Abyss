using System;

internal class rect
{
    private int v1;
    private int v2;
    private int v3;
    private int v4;
    private Action<int> showGUI;
    private string v5;

    public rect(int v1, int v2, int v3, int v4, Action<int> showGUI, string v5)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
        this.showGUI = showGUI;
        this.v5 = v5;
    }
}