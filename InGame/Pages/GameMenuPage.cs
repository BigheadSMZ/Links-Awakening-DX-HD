using System.Collections.Generic;
using Microsoft.Xna.Framework;
using ProjectZ.InGame.Controls;
using ProjectZ.InGame.Interface;
using ProjectZ.InGame.SaveLoad;
using ProjectZ.InGame.Things;

namespace ProjectZ.InGame.Pages
{
    class GameMenuPage : InterfacePage
    {
        public GameMenuPage(int width, int height)
        {
            // main layout
            var mainLayout = new InterfaceListLayout() { Size = new Point(width, height), Selectable = true };

            mainLayout.AddElement(new InterfaceLabel(Resources.GameHeaderFont, "game_menu_header",
                new Point(150, (int)(height * Values.MenuHeaderSize)), new Point(0, 0))
            { TextColor = Color.White });

            // Size = new Point(width, (int)(height * Values.MenuContentSize))
            var contentLayout = new InterfaceListLayout { AutoSize = true, Selectable = true };

            contentLayout.AddElement(new InterfaceButton(new Point(150, 25), Point.Zero, "game_menu_back_to_game", e => ClosePage()) { Margin = new Point(0, 2) });
            contentLayout.AddElement(new InterfaceButton(new Point(150, 25), Point.Zero, "game_menu_settings", OnClickSettings) { Margin = new Point(0, 2) });
            contentLayout.AddElement(new InterfaceButton(new Point(150, 25), Point.Zero, "game_menu_exit_to_the_menu", OnClickBackToMenu) { Margin = new Point(0, 2) });
            contentLayout.AddElement(new InterfaceButton(new Point(150, 25), Point.Zero, "game_menu_exit_the_game", OnClickExitGame) { Margin = new Point(0, 2) });

            mainLayout.AddElement(contentLayout);

            mainLayout.AddElement(new InterfaceListLayout { Size = new Point(width, (int)(height * Values.MenuFooterSize)) });

            PageLayout = mainLayout;
            PageLayout.Select(InterfaceElement.Directions.Top, false);
        }

        public override void OnLoad(Dictionary<string, object> intent)
        {
            Game1.GbsPlayer.Pause();

            // select the "Back to Game" button
            PageLayout.Deselect(false);
            PageLayout.Select(InterfaceElement.Directions.Top, false);
        }

        public override void OnPop(Dictionary<string, object> intent)
        {
            Game1.GbsPlayer.Resume();
        }

        public override void Update(CButtons pressedButtons, GameTime gameTime)
        {
            base.Update(pressedButtons, gameTime);

            // close the page
            if (ControlHandler.ButtonPressed(CButtons.Start) ||
                ControlHandler.ButtonPressed(CButtons.Left) ||
                ControlHandler.ButtonPressed(CButtons.B))
                ClosePage();
        }

        private void ClosePage()
        {
            Game1.GameManager.InGameOverlay.CloseOverlay();
        }

        public void OnClickSettings(InterfaceElement element)
        {
            Game1.UiPageManager.ChangePage(typeof(SettingsPage));
        }

        public void OnClickBackToMenu(InterfaceElement element)
        {
            Game1.UiPageManager.ChangePage(typeof(ExitGamePage));
        }

        public void OnClickExitGame(InterfaceElement element)
        {
            // Save the game when exiting from in-game. The quit game page is reused from the game select
            // screen where a game is not currently active. Is there a better way to do this?
            Game1.SaveAndExitGame = true;
            Game1.UiPageManager.ChangePage(typeof(QuitGamePage));
        }
    }
}
