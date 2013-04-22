using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace carrement.Piece
{
    class PieceMaster
    {
        #region variable
        #region Nombre de piece a l'init
        private int _nbPawn;
        private int _nbRook;
        private int _nbKnight;
        private int _nbBishop;
        private int _nbQueen;
        private int _nbKing;
        private int _totalPiece;
        #endregion

        #region tableau des pieces
        private List<Pawn> _tabPawn;
        private List<Rook> _tabRook;
        private List<Knight> _tabKnight;
        private List<Bishop> _tabBishop;
        private List<Queen> _tabQueen;
        private List<King> _tabKing;
        #endregion

        #region texture
        private Texture2D _textPawn;
        private Texture2D _textRook;
        private Texture2D _textKnight ;
        private Texture2D _textBishop ;
        private Texture2D _textQueen ;
        private Texture2D _textKing ;
        #endregion
        #endregion

        #region method
        public PieceMaster()
        {
            _textPawn = null;
            _textRook = null;
            _textKnight = null;
            _textBishop = null;
            _textQueen = null;
            _textKing = null;
        }
        
        public PieceMaster(Texture2D pawnText, Texture2D rookText, Texture2D knightText, Texture2D bishopText, Texture2D quennText, Texture2D kingText)
        {
            _textPawn = pawnText;
            _textRook = rookText;
            _textKnight = knightText;
            _textBishop = bishopText;
            _textQueen = quennText;
            _textKing = kingText;
          
            init();
            createAllPieces();
        }
        private void init()
        {
            _nbPawn = 8;
            _nbRook = 2;
            _nbKnight = 2;
            _nbBishop = 2;
            _nbQueen = 1;
            _nbKing = 1;
            _totalPiece = _nbPawn + _nbRook + _nbRook + _nbKnight + _nbBishop + _nbQueen + _nbKing; 

            _tabPawn = new List<Pawn>();
            _tabRook = new List<Rook>();
            _tabKnight = new List<Knight>();
            _tabBishop = new List<Bishop>();
            _tabQueen = new List<Queen>();
            _tabKing = new List<King>();

        }

        private void createAllPieces()
        {
            for (var i = 0; i < _totalPiece; i++)
            {
                if (i < _nbPawn)
                    createPawn();
                else if (i < _nbRook + _nbPawn)
                    createRook();
                else if (i < _nbKnight + _nbRook + _nbPawn)
                    createKnight();
                else if (i < _nbBishop + _nbKnight +_nbRook + _nbPawn)
                    createBishop();
                else if (i < _nbQueen + _nbBishop + _nbKnight + _nbRook + _nbPawn)
                    createQueen();
                else
                    createKing();
            }
        }

        #region create piece
        public void createPawn()
        {
            var test = new Vector2(0, 0);
            var pawn = new Pawn(_textPawn, test);
        }
        public void createBishop()
        {

        }
        public void createKnight()
        {
        }
        public void createRook()
        {

        }
        public void createQueen()
        {

        }
        public void createKing()
        {

        }
        #endregion

        public Texture2D getTexture(int type)
        {
            return null;
        }
        #endregion
    }
}
