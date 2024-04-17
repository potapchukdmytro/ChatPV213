using Server.Repositories;

namespace Server
{
    public class Config
    {
        public UserRepository UserRepository { get; init; }
        public ChatRepository ChatRepository { get; init; }
        public MessageRepository MessageRepository { get; init; }

        public Config()
        {
            AppDbContext context = new AppDbContext();
            UserRepository = new UserRepository(context);
            ChatRepository = new ChatRepository(context);
            MessageRepository = new MessageRepository(context);
        }
    }
}
