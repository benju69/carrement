using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using carrement.Player;

namespace carrement
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Board board;
        PlayerOne playerone;

        MouseState _previousState;
      

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.graphics.IsFullScreen = false;
            this.graphics.PreferredBackBufferWidth = 800;
            this.graphics.PreferredBackBufferHeight = 600;
            this.graphics.ApplyChanges();

            this.Window.Title = "Carrément !";
            base.Initialize();
        }

      
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            Texture2D tex = Content.Load<Texture2D>("damier");            
            board = new Board(tex.Height, tex.Width, tex, new Vector2(0,0));

            tex = Content.Load<Texture2D>("piece1");
            //Piece.PieceMaster
            tex = Content.Load<Texture2D>("piece2");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            /*MouseState mouseState = new MouseState();


            Rectangle buttonRect = new Rectangle((int)this.board._position.X, (int)this.board._position.Y , this.board.boardTexture.Width, this.board.boardTexture.Height);
            Point mousePoint = new Point(mouseState.X, mouseState.Y);
            Point previousPoint = new Point(_previousState.X, _previousState.Y);

            this.IsMouseOver = false;

            if (buttonRect.Contains(mousePoint))
            {
                this.IsMouseOver = true;

                if (!buttonRect.Contains(previousPoint))
                    if (OnMouseEnter != null)
                        OnMouseEnter(this);

                if (_previousState.LeftButton == ButtonState.Released && mouseState.LeftButton == ButtonState.Pressed)
                    if (OnClick != null)
                        OnClick(this);
            }
            else if (buttonRect.Contains(previousPoint))
            {
                if (OnMouseLeave != null)
                    OnMouseLeave(this);
            }

            _previousState = mouseState;*/

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            if (true)
            {
                spriteBatch.Draw(board.boardTexture, new Vector2(0, 0), Color.White);
                spriteBatch.Draw(board.boardTexture, new Vector2(0, 0), Color.White);

            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
