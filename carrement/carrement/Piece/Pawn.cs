using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace carrement.Piece
{
    class Pawn
    {
        private Vector2 _position;
        private Texture2D _textPawn;

        public Pawn(Texture2D text, Vector2 pos)
        {
            _textPawn = text;
            _position = new Vector2(pos.X, pos.Y);
        }

    }
}
