namespace GameLibrary
{
    /// <summary>
    /// Base class for different types of games.
    /// </summary>
    public abstract class Game
    {
        #region Public Methods

        /// <summary>
        /// Exits the game. This calls <see cref="OnExiting"/> method.
        /// </summary>
        public void Exit()
        {
            if (!shouldExit)
            {
                shouldExit = true;
                OnExiting();
            }
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Called before game loop started.
        /// </summary>
        protected virtual void Initialize()
        {
            shouldExit = false;
        }

        /// <summary>
        /// Called inside the game loop.
        /// </summary>
        protected abstract void Update();

        /// <summary>
        /// Override this method to add code to handle when the game is exiting.
        /// </summary>
        protected virtual void OnExiting() { }

        #endregion

        #region Private Implementation

        /// <summary>
        /// Indicator of exit from game loop.
        /// Calling method Initialize() will set this field to false.
        /// Calling method Exit() will set this field to true, causing stop of game loop.
        /// </summary>
        private bool shouldExit;

        /// <summary>
        /// Basic game loop, which stops only when method Exit() was called.
        /// </summary>
        private void MainLoop()
        {
            while (!shouldExit)
            {
                Update();
            }
        }

        #endregion

        #region Public Static Methods

        /// <summary>
        /// Begins running a basic game loop on the current thread, and makes the specified form visible.
        /// </summary>
        /// <param name="game">A Game that represents the game to start.</param>
        public static void Run(Game game)
        {
            //
            // UWAGA
            //
            // Proszę spojrzeć na modyfikatory dostępu metod Initialize() i MainLoop()
            //
            // odpowiednio protected i private
            //
            // Tak to nie pomyłka, jest to możliwe, ponieważ proszę zwrócić uwagę,
            // że aktualnie wywołana metoda jest zaimplementowana wewnątrz klasy Game.
            // Zatem dostęp jest możliwy.
            //
            game.Initialize();

            game.MainLoop();
        }

        #endregion
    }
}
