using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace HorrorAdventure.Infrastructure
{
    [Serializable]
    public abstract class BaseState
    {
        protected int buildID;
        protected string stateName;
        protected bool bCompleted;
        protected BaseState nextState;

        #region Getters and Setters
        public int BuildID { get => buildID; set => buildID = value; }
        public string StateName { get => stateName; set => stateName = value; }
        public bool Completed { get => bCompleted; set => bCompleted = value; }
        #endregion

        /// <summary>
        /// Updates states and entities relevant to this state. Also monitors whether this 
        /// state is completed and we can move on to the next one
        /// </summary>
        public abstract void Update();

        public abstract void Render(ContentManager content, SpriteBatch sbatch);
    }
}
