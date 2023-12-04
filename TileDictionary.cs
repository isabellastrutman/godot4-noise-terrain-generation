using Godot;

public class TileDictionary
{
    public static Vector2I WATER = new(0, 0);
    public static Vector2I SAND = new(2, 0);
    public static Vector2I GRASS = new(0, 2);
    public static Vector2I GRASSIER_GRASS = new(2, 4);
    public static Vector2I ROCK = new(2, 2);
    public static Vector2I ROCKIER_ROCK = new(0, 4);
}
