using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace carrement
{
    class Board
    {
        private float _width;
        private float _withTile;
        private float _height;
        private float _heightTile;

        private const int NB_TILES_WIDTH = 8;
        private const int NB_TILES_HEIGHT = 13;
        
        public Texture2D boardTexture;

        public Vector2 _position;

        public Board (float width, float height, Texture2D boardTex, Vector2 position)
        {
            _height = height;
            _width = width;
            boardTexture = boardTex;

            _withTile = _width / NB_TILES_WIDTH;
            _heightTile = _height / NB_TILES_HEIGHT;

            _position = position;
        }

        /**
         * Donne la position en pixel de la tuile
         * Param: la position de la tuile vector2(witdh, height)
         */
        public Vector2 getPositionInPx(Vector2 pos)
        {
            var vec = new Vector2(pos.X * _withTile, pos.Y * _heightTile );
            return vec;
        }

        /**
        * Donne la position de la tuile
        * Param: la position en pixel vector2(witdh, height)
        */
        public Vector2 getPosition(Vector2 pos)
        {
            var vec = new Vector2();
            return vec;
        }

    }

 
}
