namespace Ch4_Library.HuntTheWumpus
{
    public class WumpusGame
    {
        private int _playerRoom;

        public WumpusGame()
        {
            _playerRoom = 0;
        }

        public int GetPlayerRoom()
        {
            return _playerRoom;
        }

        public void SetPlayerRoom(int room)
        {
            _playerRoom = room;
        }

        public void Connect(int fromRoom, int toRoom, string direction)
        {

        }

        public void East()
        {
            _playerRoom++;
        }
    }
}
