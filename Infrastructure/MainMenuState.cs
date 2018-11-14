using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using Microsoft.Xna.Framework;

namespace HorrorAdventure.Infrastructure
{
    public class MainMenuState : BaseState
    {
        private Texture2D bkg;
        private Texture2D startButton;
        private Texture2D quitButton;

        #region Getters and Setters
        public Texture2D Background { get => bkg; set => bkg = value; }
        public Texture2D StartButton { get => startButton; set => startButton = value; }
        public Texture2D QuitButton { get => quitButton; set => quitButton = value; }
        #endregion

        public MainMenuState()
        {
            buildID = 0;
            bCompleted = false;
            stateName = "Main Menu";
        }

        public override void Render(ContentManager content, SpriteBatch sbatch)                                                      
        {
            this.bkg = content.Load<Texture2D>("background");
            sbatch.Begin();
            sbatch.Draw(bkg, Vector2.Zero);
            sbatch.End();
        }

        public override void Update()
        {
            Console.Write("updating...");
        }
        
        #region Helper functions
        
        #endregion
    }
}
