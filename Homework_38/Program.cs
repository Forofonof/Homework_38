using System;

internal class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(12, 6, '$', "forofonof");
        Render render = new Render();

        render.DrawPlayer(player.PositionX, player.PositionY, player.Symbol, player.Nickname);
    }
}

class Player
{
    public int PositionX { get; private set; }

    public int PositionY { get; private set; }

    public char Symbol { get; private set; }

    public string Nickname { get; private set; }

    public Player(int positionX, int positionY, char symbol, string nickname)
    {
        PositionX = positionX;
        PositionY = positionY;
        Symbol = symbol;
        Nickname = nickname;
    }
}

class Render
{
    public void DrawPlayer(int positionX, int positionY, char symbol, string nickaname)
    {
        Console.SetCursorPosition(positionX, positionY);
        Console.WriteLine($"{symbol} - {nickaname}");
    } 
}