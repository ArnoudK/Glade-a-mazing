using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Tile
{


    public byte Value { private set; get; }

    public readonly TileType Type;

    public Tile(TileType t = TileType.COLOR, byte val = 0)
    {
        this.Type = t;
        this.Value = val;
    }

    public enum TileType : byte
    {
        BOMB = (byte) 'B',
        COLOR,
        TARGET,
        BONUS,
        OBSTAKEL = (byte) 'O',
        DRAAI = (byte) 'R',
        START,

    }

}
