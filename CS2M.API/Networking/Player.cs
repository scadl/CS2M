namespace CS2M.API.Networking
{
    public class Player
    {
        
        public int PlayerId { get; set; }

        public string Username { get; set; }

        public long Latency { get; set; }

        private PlayerStatus _playerStatus = PlayerStatus.INACTIVE;

        public PlayerStatus PlayerStatus
        {
            get => _playerStatus;
            set
            {
                
                _playerStatus = value;
                StatusChanged?.Invoke(_playerStatus);
            }
        }

        public PlayerType PlayerType { get; set; }

        public Player()
        {
        }
        
        public event OnPlayerStatusChanged StatusChanged;
        public delegate void OnPlayerStatusChanged(PlayerStatus status);
    }
}
