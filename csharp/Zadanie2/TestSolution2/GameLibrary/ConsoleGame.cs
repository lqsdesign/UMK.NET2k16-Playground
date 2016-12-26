using System;

namespace GameLibrary
{
    /// <summary>
    /// Base class for basic console games.
    /// </summary>
    public abstract class ConsoleGame : Game
    {
        protected ConsoleGame()
        {
            Console.CancelKeyPress += Console_CancelKeyPress;
        }
        
        /// <summary>
        /// Overloaded method from <seealso cref="Game">base class</seealso>.
        /// This method obtains key pressed from <see cref="Console"/> and then call <see cref="Update(ConsoleKeyInfo)"/>.
        /// </summary>
        protected override void Update()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            Update(keyInfo);
        }

        /// <summary>
        /// Called inside the game loop.
        /// </summary>
        /// <param name="keyInfo">Obtained key form Console.</param>
        protected abstract void Update(ConsoleKeyInfo keyInfo);

        /// <summary>
        /// Sets the foreground and background console colors to their defaults.
        /// Override this method to add code to handle when the game is exiting.
        /// </summary>
        protected override void OnExiting()
        {
            Console.ResetColor();
            //Console.Clear();
        }

        #region Private Implementation

        private void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Exit();
        }

        #endregion
    }
}
