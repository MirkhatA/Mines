using UnityEngine;

public struct Cell
{
    public enum Type
    {
        Invalid,
        Empty,
        Mine,
        Diamond,
    }

    public Vector3Int position;
    public Type type;
    public bool revealed;
    public bool exploded;
}
