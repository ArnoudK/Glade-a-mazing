public class MazeBuffer
{
    private Tile[,] board = new Tile[20, 20];

    const String validTiles = "BCDEORS";
    public void load(String data)
    {
        //loading csv as a normal person is not cool enough
        int dataIndex = 0;
        int maxTileLen = data.Length - 2;
        for (int currY = 0; currY < 20; currY++)
        {
        xloop: for (int currX = 0; currX < 20; currX++)
            {
                while (!validTiles.Contains(data[dataIndex]))
                {
                    if (dataIndex < maxTileLen)
                    {
                        dataIndex++;
                    }
                    else
                    {//if we didnt fill the whole board just create black tiles
                        board[currY, currX] = new Tile();
                        goto xloop;
                    }
                }
                //we found a valid tile
                Tile.TileType t = (Tile.TileType)((byte)data[dataIndex]);//i like magic :)
                dataIndex++;
                byte val = (byte)(data[dataIndex] - '0');
                board[currX, currY] = new Tile(t, val);
            }
        }


    }


    public void print()
    {
        //1800 should be enough
        //  StringBuilder output = new StringBuilder(1800);
        Tile t;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\n\t");

        for (int i = 1; i < 21; i++)
        {
            Console.Write(i);
            Console.Write(' ');
            if (i < 10)
            {
                Console.Write(' ');
            }

        }
        Console.Write('\n');
        for (int i = 0; i < 20; i++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(((char)(i + 'A')));
            Console.Write('\t');
            for (int j = 0; j < 20; j++)
            {
                t = board[i, j];
                ConsoleColor cc = ConsoleColor.White;
                if (t.Type == Tile.TileType.COLOR)
                {
                    switch (t.Value)
                    {
                        case 0: cc = ConsoleColor.DarkGray; break;
                        case 1: cc = ConsoleColor.DarkMagenta; break;
                        case 2: cc = ConsoleColor.Blue; break;
                        case 3: cc = ConsoleColor.Green; break;
                        case 4: cc = ConsoleColor.Yellow; break;
                        case 5: cc = ConsoleColor.DarkYellow; break;
                        case 6: cc = ConsoleColor.Red; break;
                        case 7: cc = ConsoleColor.Gray; break;
                        default: break;


                    }
                } 
                 
                Console.ForegroundColor = cc;

                Console.Write((char)t.Type);
                Console.Write(t.Value);
                Console.Write(' ');
            }
            Console.Write('\n');
        }
        //Console.Write(output);
    }

}
